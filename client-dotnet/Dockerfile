FROM microsoft/dotnet

RUN mkdir /myapp
WORKDIR /myapp

ADD client-dotnet.csproj /myapp/client-dotnet.csproj
RUN dotnet restore

ADD . /myapp
