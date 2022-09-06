# My Exercises
RENAME THIS FILE TO "Exercises - Firsname Lastname.md" and put the content of this file into it.
FILES WITH OTHER NAMES WILL BE REJECTED!

#### Exercise I 

Provide script samples used in this exercise. What did you do , why, how, what was the result.
If you have your scrips somwhere on the git, provide us als the URL here to them.
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%201/az%20login.PNG

az group list This command is used to show the list of current groups in the account
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%201/az%20resource%20group.PNG

az group list --tag key1=America This command is used to show the groups containing key1 value America
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%201/Resource%20Group.PNG


#### Exercise 2 - Docker in Azure
Provide URL to the docker file. I.e.: %giturl%\Source\MyCloudProjectSample\MyCloudProject\Dockerfile #See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build WORKDIR /src COPY ["ConsoleApp1/ConsoleApp1.csproj", "ConsoleApp1/"] RUN dotnet restore "ConsoleApp1/ConsoleApp1.csproj" COPY . . WORKDIR "/src/ConsoleApp1" RUN dotnet build "ConsoleApp1.csproj" -c Release -o /app/build

FROM build AS publish RUN dotnet publish "ConsoleApp1.csproj" -c Release -o /app/publish FROM base AS final WORKDIR /app COPY --from=publish /app/publish . ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
1. Provide URL to the docker file. I.e.: %giturl%\Source\MyCloudProjectSample\MyCloudProject\Dockerfile
 https://hub.docker.com/repository/docker/naveed401/exer2
3. Provide the URL to the publich image in the Docker Hub. https://hub.docker.com/layers/213018519/naveed401/cloudtutor/1st/images/sha256-b1134c3cf335d2de2eabaefc1c5405a4547eae3d2678db9fa205f6d1da480c6e?context=repo
4. Provide the URL to the private(public??) image in the Azure Registry.https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%202/az%20container.PNG

#### Exercise 3 - Host a web application with Azure App service

1. Provide the public URL of the webapplication. https://bestapp.azurewebsites.net
2. Provide the URL to the source code of the hosted application. (Source code somwhere or the the docker image, or ??)
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/tree/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%203/bestapp/pub
3. Provide AZ scripts used to bublish the application.
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%203/script.txt

#### Exercise 4 - Deploy and run the containerized app in AppService

1. Provide URL to the docker image of your application (Docker Hub / Azure Registry). https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%204/Image%20Pushed%20to%20acr.PNG
2. Provide the public URL to the running application. https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%204/Pushing%20docker%20image%20into%20acr.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%204/Script.txt

#### Exercise 5 - Blob Storage

Provide the URL to to blob storage container under your account.
We should find some containers and blobs in there.
Following are mandatory:
- Input
Contains training files
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%205/storage%20blob.PNG
- Output
Contains output of the traned models
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%205/files%20storage.PNG

- 'Test' for playing and testing.
you should provide here SAS Url to 2-3 files in this container with time expire 1 year.
https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Exercise/Exercise%205/empty%20folder.PNG
#### Exercise 6 - Table Storage

Provide us access to the account which you have used for table exersises. https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%206/Snaps/table1.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%206/Snaps/2.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%206/Snaps/3.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%206/Snaps/4.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%206/Snaps/5.PNG

#### Exercise 7 - Queue Storage

Provide us access to the account which you have used for queue exersises. https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/1.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/Queue%20Sending%20Multiple%20Messages.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/Receiving%20Multiple%20Messages.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/Sending%20Messages.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/Sending%20Multiple%20Messages.PNG

https://github.com/UniversityOfAppliedSciencesFrankfurt/se-cloud-2021-2022/blob/Naveed-Ahmad/Source/MyCloudProjectSample/Documentation/Cloud%20Exercises/Exercise%207/Storage%20Message.PNG
