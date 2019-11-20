FROM mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04
 
COPY *.sh /
COPY UpsertSql.sql /
 
CMD /bin/bash ./entrypoint.sh