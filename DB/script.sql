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
   pid                  int not null comment '父目录id',
   name                 varchar(30) not null comment '目录名称',
   sort                 int not null comment '排序',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table class comment '目录表';

/*==============================================================*/
/* Table: doc                                                   */
/*==============================================================*/
create table doc
(
   id                   int not null comment 'ID',
   name                 varchar(30) not null comment '团队名称',
   comment              varchar(100) comment '团队说明',
   class                int not null comment '文档目录',
   title                varchar(100) not null comment '文档标题',
   type                 int not null comment '文档类别',
   content              text comment '文档内容',
   function             varchar(10) not null comment '方法名',
   delflag              datetime not null comment '删除标记',
   primary key (id)
);

alter table doc comment '接口文档表';

/*==============================================================*/
/* Table: groups                                                */
/*==============================================================*/
create table groups
(
   id                   int not null comment 'ID',
   name                 varchar(30) not null comment '团队名称',
   comment              varchar(100) comment '团队说明',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table groups comment '团队表';

/*==============================================================*/
/* Table: parameter                                             */
/*==============================================================*/
create table parameter
(
   id                   int not null comment 'ID',
   docid                int not null comment '接口id',
   parameter            varchar(30) not null comment '参数名称',
   type                 int not null comment '参数类型',
   comment              varchar(100) comment '参数说明',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table parameter comment '接口参数表';

/*==============================================================*/
/* Table: project                                               */
/*==============================================================*/
create table project
(
   id                   int not null comment 'ID',
   name                 varchar(20) not null comment '项目名称',
   state                int not null comment '项目状态',
   userid               int not null comment '用户id',
   comment              varchar(100) comment '项目说明',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table project comment '项目表';

/*==============================================================*/
/* Table: projectgroup                                          */
/*==============================================================*/
create table projectgroup
(
   id                   int not null comment 'ID',
   projectid            int not null comment '项目id',
   groupid              int not null comment '团队id',
   primary key (id)
);

alter table projectgroup comment '项目团队表';

/*==============================================================*/
/* Table: usergroup                                             */
/*==============================================================*/
create table usergroup
(
   id                   int not null comment 'ID',
   userid               int not null comment '用户id',
   groupid              int not null comment '团队id',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table usergroup comment '用户团队表';

/*==============================================================*/
/* Table: users                                                 */
/*==============================================================*/
create table users
(
   id                   int not null comment 'ID',
   code                 varchar(20) not null comment '登录帐号',
   pass                 varchar(20) not null comment '登录密码',
   email                varchar(20) comment '邮箱',
   name                 varchar(50) comment '真实姓名',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              int not null comment '删除标记',
   primary key (id)
);

alter table users comment '用户信息表';

/*==============================================================*/
/* Table: "values"                                              */
/*==============================================================*/
create table "values"
(
   id                   int not null comment 'ID',
   docid                varchar(30) not null comment '接口id',
   type                 int not null comment '类型',
   link                 int comment '外链',
   content              text comment '内容',
   idate                datetime not null comment '新增时间',
   udate                datetime not null comment '更新时间',
   delflag              datetime not null comment '删除标记',
   primary key (id)
);

alter table "values" comment '接口返回表';

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
