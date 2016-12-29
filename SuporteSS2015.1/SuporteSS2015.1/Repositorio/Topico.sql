CREATE TABLE [dbo].[postagem] (
    [id_postagem]     INT      IDENTITY (1, 1) NOT NULL,
    [id_topico_forum] INT      NOT NULL,
    [id_usuario]      NVARCHAR(128)  NOT NULL,
    [mensagem]        TEXT     NULL,
    [data_publicacao] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([id_postagem] ASC),
    FOREIGN KEY ([id_topico_forum]) REFERENCES [dbo].[topico_forum] ([id_topico_forum]),
    FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

GO
CREATE NONCLUSTERED INDEX [postagem_FKIndex]
    ON [dbo].[postagem]([id_usuario] ASC);
GO
CREATE NONCLUSTERED INDEX [IFK_Rel_Topico_Postagem]
    ON [dbo].[postagem]([id_topico_forum] ASC);
GO
CREATE NONCLUSTERED INDEX [IFK_Rel_Usuario__Postagem]
    ON [dbo].[postagem]([id_usuario] ASC);

