# Extending-LinQ-Provider-nHibernate

In order to run this demo, you need 2 things:

- A table in Database with the below structure:

CREATE TABLE Person(
  id int identity,
  name nvarchar(max),
  age int
  );

- Change the connection string in App.config

```<property name="connection.connection_string">Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestnHibernate;Integrated Security=True</property>```
