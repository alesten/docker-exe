FROM microsoft/dotnet

RUN mkdir /myapp
WORKDIR /myapp

ADD server-dotnet.csproj /myapp/server-dotnet.csproj
RUN dotnet restore

ADD . /myapp
