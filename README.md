# HMS (In progress)
Hospital Management System (HMS) will consist in three main sub-systems:
a Patient Management System (PMS), a Medical-Supply Management System (MMS) and a
Ward Staffing Management System (SMS). The three sub-systems are functionally independent.
This would allow added functionalities such as balancing staffing needs with wards occupancy.
<br>
# To run the code
<h3>Step 1 : Download and Run the SQL Server Docker Image</h3>

```
docker run -it \
    -e "ACCEPT_EULA=Y" \
    -e "HMS_PASSWORD=HMSAdmin" \
    -p 1433:1433 \
    --name sql-server-HMS \
    mcr.microsoft.com/mssql/server:2022-latest
```
<br>This will install and run sql locally. You can you this `docker start -i sql-server-2022` to run the container again letter.
