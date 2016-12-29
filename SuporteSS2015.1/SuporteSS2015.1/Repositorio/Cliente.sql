     CREATE TABLE topico_forum(
       id_topico_forum INTEGER  NOT NULL   IDENTITY ,
       nome VARCHAR(100) ,
       descricao VARCHAR(100),
       data_cadastro DATETIME ,
     PRIMARY KEY(id_topico_forum));
     GO
     
     CREATE TABLE postagem(
       id_postagem INTEGER  NOT NULL   IDENTITY ,
       id_topico_forum INTEGER  NOT NULL,
       id_usuario INTEGER NOT NULL,
       mensagem TEXT,
       data_publicacao DATETIME,
     PRIMARY KEY(id_postagem)    ,
       FOREIGN KEY(id_topico_forum)
         REFERENCES topico_forum(id_topico_forum),
       FOREIGN KEY(id_usuario)
         REFERENCES AspNetUserClaims(id));
     GO
     
     CREATE INDEX postagem_FKIndex  ON postagem(id_usuario);
     GO
     CREATE INDEX postagem_FKIndex  ON postagem(id_topico_forum);
     GO
     CREATE INDEX IFK_Rel_Topico_Postagem ON postagem(id_topico_forum);
     GO
     CREATE INDEX IFK_Rel_Usuario__Postagem ON postagem(id_usuario);
     GO