# SearchUser.API
This API has endpoints to search user.
# Introduction
The aim of this application is to provide various endpoints for user operations like Search etc.

# Getting Started
##	Using Visual Studio

### Installation
1. On 'GitHub' within Visual Studio connect to a project and clone the repository https://github.com/keerthisomidi86/SearchUser.API.git

# Build and Test
1. Currently the system builds and runs locally on iisexpress as it's not deployed or hosted anywhere on the servers.

# Hosting
1.The project is currently not hosted on any servers.

# Dependencies
There are no external dependencies at this time.

# Contribute
# API Definition
## Endpoints
### Request

`GET api/User/Search`

    curl -i -H 'Accept: application/json' -d 'searchStr=james' http://localhost:7091/api​/User​/Search

### Response

    HTTP/1.1 200 OK
    Date: Wed, 25 Oct 2023 21:36:30 GMT
    Status: 200 OK
    Connection: close
    content-type: application/json; charset=utf-8 
    server: Kestrel 

[{"id": 8,"firstName": "James","lastName": "kubu","emailAddress": "jkubu7@craigslist.org","gender": "Male"},{"id": 11,"firstName": "James","lastName": "Pfeffer","emailAddress": "bpfeffera@amazon.com","gender": "Male"}]
