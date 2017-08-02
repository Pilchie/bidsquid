#!/bin/bash

docker-compose -f docker-compose.yml -f docker-compose.override.yml -f docker-compose.g.yml up -d --build
docker exec -d src_bidsquid-web_1 dotnet --additionalProbingPath /root/.nuget/packages --additionalProbingPath /root/.nuget/fallbackpackages bin/Debug/netcoreapp2.0/bidsquid-web.dll