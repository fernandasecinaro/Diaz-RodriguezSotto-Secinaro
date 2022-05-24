# Create and Run container
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Passw0rd1" \
	-p 1433:1433 --name sql1 --hostname sql1 \
	-d mcr.microsoft.com/mssql/server:2019-latest

# Create backup directory on docker container
docker exec -it sql1 mkdir /var/opt/mssql/backup

# Copy .bak with data to the docker container
docker cp './Con datos/NaturalUruguayDB (Con datos).bak' sql1:/var/opt/mssql/backup/
