# Unity Nakama Auth Project


This project is a Unity client with login, registration, and password reset functionality using a Nakama server (running in Docker).



## Structure

- `UnityClient/` - Unity project

- `NakamaServer/` - Docker + Nakama setup


## Running Nakama

```bash

cd NakamaServer

docker compose up

- type in your browser localhost:7351 to manage user account logins and stautus of nakama client.
- in order to access prometheaus and the cocraoach-db in your browser, view their ports from the docker process

##Running Unity Client
- Install unity hub and make sure the editor version 2022.3.32f1 is installed.
- Open the project in unity editor and play it, the welcome interface allows you to connect and you can create or login if you are exisitng user
