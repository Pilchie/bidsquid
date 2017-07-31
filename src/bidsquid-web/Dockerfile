FROM microsoft/aspnetcore-nightly:2.0
ARG source
WORKDIR /app
EXPOSE 80
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "bidsquid-web.dll"]