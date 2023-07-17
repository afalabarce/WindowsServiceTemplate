# WindowsServiceTemplate
This is a little project to show how create a service for the Windows Operating System.

## Deploy the service

To deploy your service, you only need execute this command as Administrator:

```bash
> sc.exe create CustomService start=auto binPath="<Path to File>\service.exe" DisplayName="My Custom Service"

```

## Delete the service

To remove your service from the Service catalog, you only need execute this command as Administrator:


```bash
> sc.exe sc.exe delete CustomService

```

if you think I've done a good job, and you think I deserve a coffee, you can invite me with [![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https:// ko-fi.com/R5R4NB8VV)
