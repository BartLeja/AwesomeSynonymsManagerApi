# AwesomeSynonymsManagerApi
AwesomeSynonymsManagerApi is epic endpoint for collections of words with their synonyms. This great API will help you gather all you favorite words with their synonyms and save them into database ;-)

To run this api crete MS SQL Server database with name SynonymsManagerDB and create table Synonyms
```sql
CREATE TABLE Synonyms (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Term varchar(255) NOT NULL,
    Synonyms varchar(max),
);
```
After runing the script, change connection string in appsettings.json file
