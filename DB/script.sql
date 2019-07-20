drop table if exists class;

drop table if exists doc;

drop table if exists groups;

drop table if exists parameter;

drop table if exists project;

drop table if exists projectgroup;

drop table if exists usergroup;

drop table if exists users;

drop table if exists "values";

/*==============================================================*/
/* Table: class                                                 */
/*==============================================================*/
create table class
(
   id                   int not null comment 'ID',
   pid                  int not null comment '��Ŀ¼id',
   name                 varchar(30) not null comment 'Ŀ¼����',
   sort                 int not null comment '����',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table class comment 'Ŀ¼��';

/*==============================================================*/
/* Table: doc                                                   */
/*==============================================================*/
create table doc
(
   id                   int not null comment 'ID',
   name                 varchar(30) not null comment '�Ŷ�����',
   comment              varchar(100) comment '�Ŷ�˵��',
   class                int not null comment '�ĵ�Ŀ¼',
   title                varchar(100) not null comment '�ĵ�����',
   type                 int not null comment '�ĵ����',
   content              text comment '�ĵ�����',
   function             varchar(10) not null comment '������',
   delflag              datetime not null comment 'ɾ�����',
   primary key (id)
);

alter table doc comment '�ӿ��ĵ���';

/*==============================================================*/
/* Table: groups                                                */
/*==============================================================*/
create table groups
(
   id                   int not null comment 'ID',
   name                 varchar(30) not null comment '�Ŷ�����',
   comment              varchar(100) comment '�Ŷ�˵��',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table groups comment '�Ŷӱ�';

/*==============================================================*/
/* Table: parameter                                             */
/*==============================================================*/
create table parameter
(
   id                   int not null comment 'ID',
   docid                int not null comment '�ӿ�id',
   parameter            varchar(30) not null comment '��������',
   type                 int not null comment '��������',
   comment              varchar(100) comment '����˵��',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table parameter comment '�ӿڲ�����';

/*==============================================================*/
/* Table: project                                               */
/*==============================================================*/
create table project
(
   id                   int not null comment 'ID',
   name                 varchar(20) not null comment '��Ŀ����',
   state                int not null comment '��Ŀ״̬',
   userid               int not null comment '�û�id',
   comment              varchar(100) comment '��Ŀ˵��',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table project comment '��Ŀ��';

/*==============================================================*/
/* Table: projectgroup                                          */
/*==============================================================*/
create table projectgroup
(
   id                   int not null comment 'ID',
   projectid            int not null comment '��Ŀid',
   groupid              int not null comment '�Ŷ�id',
   primary key (id)
);

alter table projectgroup comment '��Ŀ�Ŷӱ�';

/*==============================================================*/
/* Table: usergroup                                             */
/*==============================================================*/
create table usergroup
(
   id                   int not null comment 'ID',
   userid               int not null comment '�û�id',
   groupid              int not null comment '�Ŷ�id',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table usergroup comment '�û��Ŷӱ�';

/*==============================================================*/
/* Table: users                                                 */
/*==============================================================*/
create table users
(
   id                   int not null comment 'ID',
   code                 varchar(20) not null comment '��¼�ʺ�',
   pass                 varchar(20) not null comment '��¼����',
   email                varchar(20) comment '����',
   name                 varchar(50) comment '��ʵ����',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              int not null comment 'ɾ�����',
   primary key (id)
);

alter table users comment '�û���Ϣ��';

/*==============================================================*/
/* Table: "values"                                              */
/*==============================================================*/
create table "values"
(
   id                   int not null comment 'ID',
   docid                varchar(30) not null comment '�ӿ�id',
   type                 int not null comment '����',
   link                 int comment '����',
   content              text comment '����',
   idate                datetime not null comment '����ʱ��',
   udate                datetime not null comment '����ʱ��',
   delflag              datetime not null comment 'ɾ�����',
   primary key (id)
);

alter table "values" comment '�ӿڷ��ر�';

alter table class add constraint FK_class_class foreign key (pid)
      references class (id) on delete restrict on update restrict;

alter table doc add constraint FK_doc_class foreign key (class)
      references class (id) on delete restrict on update restrict;

alter table doc add constraint FK_doc_project foreign key (name)
      references project (id) on delete restrict on update restrict;

alter table doc add constraint FK_doc_users foreign key (comment)
      references users (id) on delete restrict on update restrict;

alter table parameter add constraint FK_parameter_doc foreign key (docid)
      references doc (id) on delete restrict on update restrict;

alter table project add constraint FK_project_users foreign key (userid)
      references users (id) on delete restrict on update restrict;

alter table projectgroup add constraint FK_group_join_project foreign key (groupid)
      references groups (id) on delete restrict on update restrict;

alter table projectgroup add constraint FK_project_join_group foreign key (projectid)
      references project (id) on delete restrict on update restrict;

alter table usergroup add constraint FK_group_join_users foreign key (groupid)
      references groups (id) on delete restrict on update restrict;

alter table usergroup add constraint FK_users_jion_group foreign key (userid)
      references users (id) on delete restrict on update restrict;

alter table "values" add constraint FK_values_doc foreign key (docid)
      references doc (id) on delete restrict on update restrict;
