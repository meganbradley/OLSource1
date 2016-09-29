---
title: "Walkthrough: Using LightSwitch Data in a Windows Store App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0273d9ab-a551-4915-81bb-e3eee5e06c74
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using LightSwitch Data in a Windows Store App
By following this walkthrough, you can learn how to create or configure a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app or other application that supports the Open Data Protocol (OData) to consume data from any LightSwitch application.  
  
## Prerequisites  
 To complete this walkthrough, you must be running [!INCLUDE[vs_dev11_long](../VS_csharp/includes/vs_dev11_long_md.md)] on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)]. You’ll also need to download the Contoso Construction application from the [MSDN Samples Gallery](http://go.microsoft.com/fwlink/?LinkID=208915) on the Microsoft website and follow the setup instructions in the readme.txt file. If you’ve never created a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app before, you’ll be prompted to acquire a developer license when you create the project for the [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app.  
  
### To expose an OData data source  
  
1.  On the menu bar, choose **File**, **Open**, **Project/Location**.  
  
2.  In the **Open Project** dialog box, browse to the ContosoConstruction.sln file, and then open it.  
  
3.  In **Solution Explorer**, open the shortcut menu for **Properties**, and then choose **Open**.  
  
4.  In the **Application Designer**, choose the **Edit DesktopClient properties** link.  
  
5.  In the **Desktop Client** designer, choose the **Client Type** tab.  
  
6.  In the **Client** section, choose the **Web** option button.  
  
     This procedure exposes both of the data sources for the Contoso Construction application as OData feeds.  
  
### To create the Windows Store app  
  
1.  On the menu bar, choose **File**, **Add**, **New Project**.  
  
2.  In the list of project types for **JavaScript**, choose **Split Application**.  
  
3.  In the **Name** text box, specify `ContosoProjects`, and then choose the **OK** button.  
  
     The **ContosoConstruction** project is added to the solution.  
  
### To add script libraries  
  
1.  On the menu bar, choose **Tools**, **Library Package Manager**, **Package Manager Console**.  
  
     The **Package Manager Console** window opens.  
  
2.  At the **Package Manager Console** command prompt, enter `install-package jquery`, and then choose the Enter key.  
  
3.  After the command completes, enter `install-package datajs`, and then choose the Enter key.  
  
     After the command completes, the following [!INCLUDE[javascript](../VS_csharp/includes/javascript_md.md)] files appear in the **Scripts** folder in **Solution Explorer**:  
  
    -   datajs-1.0.2.js  
  
    -   datajs-1.0.2.min.js  
  
    -   jquery-1.7.1.js  
  
    -   jquery-1.7.1.min.js  
  
    -   jquery-1.7.1.-vsdoc.js  
  
### To modify the Windows Store app  
  
1.  In **Solution Explorer**, open the default.html file.  
  
2.  Under the `WinJS references` section, add the following references:  
  
    ```html  
    <!-- jQuery references -->   
      <script src="/Scripts/jquery-1.7.1.js"></script>   
      <!-- datajs references -->   
      <script src="/Scripts/datajs-1.0.2.js"></script>  
  
    ```  
  
3.  In **Solution Explorer**, expand the **js** node, and then open the default.js file.  
  
4.  Under the `var app = WinJS.Application;` line, add the following variable:  
  
    ```javascript  
    var OData = window.OData;  
    ```  
  
5.  In **Solution Explorer**, open the data.js file.  
  
6.  Replace the code in the `sampleGroups` section with the following code:  
  
    ```javascript  
    var sampleGroups = [   
            {  
                key: "allProjects", title: "All Projects", subtitle: "All Contoso projects.",  
                backgroundImage: darkGray  
            },  
        ];  
    ```  
  
7.  Locate the function after the comment `// TODO: Replace the data with your real data.`, and replace the existing code with the following code:  
  
    ```javascript  
    //Generic function for loading data via a odata url  
        function loadData(data, odataUrl, dataLoaded) {  
            if (data) {  
                return WinJS.Promise.as(data);  
            }  
            else {  
                return new WinJS.Promise(function (complete, error, progress) {  
                    OData.read(odataUrl,  
                    function (data) {  
                        complete(dataLoaded(data.results));  
                    },  
                    function (dataerror) {  
                        error(dataerror);  
                    });  
                });  
            }  
        }  
  
        var projectsODataUrl = "http://localhost:#####/ApplicationData.svc/Projects";  
        //TODO: Replace projectsODataUrl with url for deployed OData service  
        //  before publishing this application.  
        var _projects;  
        //Loads projects  
        function loadProjects() {  
            loadData(_projects, projectsODataUrl, function (results) {  
                _projects = results;  
                return _projects;  
            }).then(function (projects) {  
                var items = [];  
  
                $.each(projects, function (l, e) {  
                    var notes;  
                    if (e.Notes === null) {  
                        notes = "";  
                    }  
                    else {  
                        notes = e.Notes;  
                    }  
                    items.push({  
                        displayName: e.ProjectName, subtitle: "Estimate: $" +  
                            e.OriginalEstimate, description: "", content: notes  
                    });  
                });  
                showProjects(items.sort(), sampleGroups[0]);  
            });  
        }  
  
        //Adds projects to binding list.  
        function showProjects(items, itemGroup) {  
            items.forEach(function (item) {  
                list.push(  
                    {  
                        group: itemGroup, title: item.displayName,  
                        subtitle: item.subtitle, description: item.description,  
                        content: item.content, backgroundImage: lightGray  
                    }  
                  )  
            });  
        }  
  
        loadProjects();  
    ```  
  
### To specify capabilities for the Windows Store app  
  
1.  In **Solution Explorer**, open the package.appxmanifest file.  
  
2.  On the **Capabilities** tab, select the **Private Networks (Client and Server)** check box.  
  
     This procedure enables an enterprise app to access Intranet resources. This setting isn’t necessary for typical [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] apps from the [!INCLUDE[win8_appstore_long](../VS_csharp/includes/win8_appstore_long_md.md)].  
  
### To debug and test the application  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Solution** node, and then choose **Properties**.  
  
2.  Choose the **Multiple startup projects** option button.  
  
3.  In the **Action** column, choose **Start** for both the **ContosoConstruction** and **ContosoProjects** projects.  
  
    > [!IMPORTANT]
    >  Make sure that **ContosoContruction** is listed before **ContosoProjects** in the startup order.  
  
4.  In **Solution Explorer**, open the data.js file.  
  
5.  In the line that starts `return new WinJS.Promise`, set a breakpoint.  
  
6.  Choose the F5 key to start debugging.  
  
     The application will start to load and then stop running when the breakpoint is reached.  
  
7.  In the browser window where the Contoso Construction application is running, copy the port number from the Address Bar.  
  
     The port number is the numeric value that follows `http://localhost:` in the URL.  
  
8.  In the **Immediate** window, enter `odataUrl = http://localhost:#####/ApplicationData.svc/Projects`, substituting the port number for *#####*, and then choose the Enter key.  
  
9. Choose the F5 key to resume loading the Contoso Projects app.  
  
     The Contoso Projects app appears.  
  
10. Choose the **All Projects** button to display a list of projects from the Contoso Construction application.  
  
## Next Steps  
 When you are ready to deploy the app, you must publish each project independently. First, you publish the LightSwitch application to your production server. After the LightSwitch application is deployed and you know the OData service URL for the production server, you update the port number in the data.js file for the [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app before you then deploy it.  
  
## See Also  
 [LightSwitch as a Data Source](../VS_csharp/lightswitch-as-a-data-source.md)   
 [How to: Deploy a 3-tier Application](../VS_csharp/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [How to: Deploy a Windows Store Application](http://go.microsoft.com/fwlink/?LinkID=248603)