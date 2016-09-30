---
title: "Using the IntelliTrace stand-alone collector"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.historicaldebug.collectdataoutsideVS"
helpviewer_keywords: 
  - "IntelliTrace, debugging applications in production"
ms.assetid: 1bde9807-8219-4a2a-a440-ac5ee5178159
caps.latest.revision: 109
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the IntelliTrace stand-alone collector
The **IntelliTrace stand-alone collector** lets you collect IntelliTrace diagnostic data for your apps on production servers or other environments without installing Visual Studio on the target machine and without changing the target system's environment. The IntelliTrace stand-alone collector works on web, SharePoint, WPF and Windows Forms apps. When you're done collecting data, just delete the collector to uninstall it.  
  
 Watch IntelliTrace in action: [Collecting and analyzing IntelliTrace data in production for debugging (Channel 9 video)](http://go.microsoft.com/fwlink/?LinkID=251851)  
  
> [!NOTE]
>  You can also collect the same IntelliTrace data for web and SharePoint apps running on remote machines by using the **Microsoft Monitoring Agent** in **Trace** mode.  
>   
>  You can collect performance-related events in the IntelliTrace data by running the agent in **Monitor** mode. **Monitor** mode has less of a performance impact than **Trace** mode or the **IntelliTrace stand-alone collector**. Microsoft Monitoring Agent does alter the target system's environment when it is installed. See [Collect IntelliTrace diagnostic and performance data in production by using the Microsoft Monitoring Agent](../vs140/using-the-microsoft-monitoring-agent.md).  
  
 **Requirements**  
  
-   .NET Framework 3.5, 4, or 4.5  
  
-   Visual Studio Enterprise (but not Professional or Community editions) on a development computer or other computer to open .iTrace files  
  
    > [!NOTE]
    >  Make sure to save your symbol (.pdb) files. To debug with IntelliTrace and step through code, you must have the matching source files and symbol files. See [Set up your release to diagnose problems after deployment](../vs140/diagnose-problems-after-deployment.md).  
  
 **FAQ**  
  
-   [What apps work with the collector?](#WhatApps)  
  
-   [How do I get started?](#GetStarted)  
  
-   [How can I get the most data without slowing down my app?](#Minimizing)  
  
-   [Where else can I get IntelliTrace data?](#WhereElse)  
  
##  \<a name="WhatApps">\</a> What apps work with the collector?  
  
-   ASP.NET Web apps hosted on Internet Information Services (IIS) version 7.0, 7.5, and 8.0  
  
-   SharePoint 2010 and SharePoint 2013 applications  
  
-   Windows Presentation Foundation (WPF) and Windows Forms apps.  
  
##  \<a name="GetStarted">\</a> How do I get started?  
  
1.  [Install the collector.](#BKMK_Install_the_IntelliTrace_Stand_Alone_Collector)  
  
2.  [Set up permissions for the collector directory.](#ConfigurePermissionsRunningCollector)  
  
3.  [For Web apps and SharePoint applications, install the IntelliTrace PowerShell cmdlets](#BKMK_Set_up_the_IntelliTrace_PowerShell_commandlets)  
  
4.  [Set up permissions for the .iTrace file directory](#BKMK_Create_and_Configure_a_Log_File_Directory)  
  
5.  [Collect data from a Web app or SharePoint application](#BKMK_Collect_Data_from_IIS_Application_Pools)  
  
     -or-  
  
     [Collect data from a managed app](#BKMK_Collect_Data_from_Executables)  
  
6.  [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)  
  
##  \<a name="BKMK_Install_the_IntelliTrace_Stand_Alone_Collector">\</a> Install the collector  
  
1.  On your app’s server, create the collector directory, for example: **C:\IntelliTraceCollector**  
  
2.  Get the collector from the Microsoft Download Center or from the Visual Studio 2103 Update 3 installation folder. [IntelliTrace Collector for Visual Studio 2013 Update 4](https://www.microsoft.com/en-us/download/details.aspx?id=44909)::  
  
    -   **Microsoft Download Center**:  
  
        1.  Next to **IntelliTraceCollector.exe**, choose **Download**.  
  
        2.  Save IntelliTraceCollector.exe to the collector directory, for example: **C:\IntelliTraceCollector**  
  
        3.  Run IntelliTraceCollector.exe. This extracts the IntelliTraceCollection.cab file.  
  
         \- or -  
  
    -   **Visual Studio installation folder**:  
  
        1.  Copy IntelliTraceCollection.cab from the following folder:  
  
             **..\Microsoft Visual Studio 12.0\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace\12.0.0**  
  
        2.  Put IntelliTraceCollection.cab in the collector directory, for example: **C:\IntelliTraceCollector**  
  
3.  Expand IntelliTraceCollection.cab:  
  
    1.  On your app’s server, open a command prompt window as an administrator.  
  
    2.  Browse to the collector directory, for example: **C:\IntelliTraceCollector**  
  
    3.  Use the **expand** command, including the period (**.**) at the end, to expand IntelliTraceCollection.cab:  
  
         <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
        > [!NOTE]
        >  The period (**.**) preserves the subfolders that contain localized collection plans.  
  
##  \<a name="ConfigurePermissionsRunningCollector">\</a> Set up permissions for the collector directory  
  
1.  On your app’s server, open a command prompt window as an administrator.  
  
2.  Use the Windows **icacls** command to give the server administrator full permissions to the collector directory. For example:  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> *\<Domain\AdministratorID>* <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
3.  To collect data for a Web app or SharePoint application:  
  
    1.  Give the person who will run the IntelliTrace PowerShell cmdlets full permissions to the collector directory.  
  
         For example:  
  
         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> *\<Domain\UserID>* <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
    2.  Give the application pool for the Web app or SharePoint application read and execute permissions to the collector directory.  
  
         For example:  
  
        -   For a Web app in the **DefaultAppPool** application pool:  
  
             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
        -   For a SharePoint application in the **SharePoint - 80** application pool:  
  
             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
##  \<a name="BKMK_Set_up_the_IntelliTrace_PowerShell_commandlets">\</a> Install IntelliTrace PowerShell cmdlets to collect data for Web apps or SharePoint applications  
  
1.  On your app’s server, make sure that PowerShell is enabled. On most versions of Windows Server, you can add this feature in the **Server Manager** administrative tool.  
  
     ![Adding PowerShell by using Server Manager](../vs140/media/intellitrace_servermanager_addpowershell.png "INTELLITRACE_ServerManager_AddPowerShell")  
  
2.  Install the IntelliTrace PowerShell cmdlets.  
  
    1.  Open a PowerShell command window as an administrator.  
  
        1.  Choose **Start**, **All Programs**, **Accessories**, **Windows PowerShell**.  
  
        2.  Choose one of the following steps:  
  
            -   On 64-bit operating systems, open the shortcut menu for **Windows PowerShell**. Choose **Run as administrator**.  
  
            -   On 32-bit operating systems, open the shortcut menu for **Windows PowerShell (x86)**. Choose **Run as administrator**.  
  
    2.  In the PowerShell command window, use the **Import-Module** command to import **Microsoft.VisualStudio.IntelliTrace.PowerShell.dll**.  
  
         For example:  
  
         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
##  \<a name="BKMK_Create_and_Configure_a_Log_File_Directory">\</a> Set up permissions for the .iTrace file directory  
  
1.  On your app’s server, create the .iTrace file directory, for example: **C:\IntelliTraceLogFiles**  
  
    > [!NOTE]
    >  -   To avoid slowing down your app, choose a location on a local high-speed disk that’s not very active.  
    > -   You can put .iTrace files and the collector files in the same place. However, if you have a Web app or SharePoint application, make sure this place is outside the directory that hosts the application.  
  
    > [!IMPORTANT]
    >  -   Restrict the .iTrace file directory only to those identities that must work with the collector. An .iTrace file might contain sensitive information, such as data from users, databases, other source locations, and connection strings because IntelliTrace can record any data that passes into method parameters or as return values.  
    > -   Make sure those who can open .iTrace files have the authority to view sensitive data. Use caution when sharing .iTrace files. If other people must have access, copy the files to a secure shared location.  
  
2.  For a Web app or SharePoint application, give its application pool full permissions to the .iTrace file directory. You can use the Windows **icacls** command or use Windows Explorer (or File Explorer).  
  
     For example:  
  
    -   To set up permissions with the Windows **icacls** command:  
  
        -   For a Web app in the **DefaultAppPool** application pool:  
  
             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
        -   For a SharePoint application in the **SharePoint - 80** application pool:  
  
             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
         -or-  
  
    -   To set up permissions with Windows Explorer (or File Explorer):  
  
        1.  Open **Properties** for the .iTrace file directory.  
  
        2.  On the **Security** tab, choose **Edit**, **Add**.  
  
        3.  Make sure **Built-in security principals** appears in the **Select this object type** box. If it’s not there, choose **Object Types** to add it.  
  
        4.  Make sure your local computer appears in the **From this location** box. If it’s not there, choose **Locations** to change it.  
  
        5.  In the **Enter the object names to select** box, add the application pool for the Web app or SharePoint application.  
  
        6.  Choose **Check Names** to resolve the name. Choose **OK**.  
  
        7.  Make sure the application pool has **Full control**.  
  
##  \<a name="BKMK_Collect_Data_from_IIS_Application_Pools">\</a> Collect data from a Web app or SharePoint application  
  
1.  To start collecting data, open a PowerShell command window as an administrator, then run this command:  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> *\<ApplicationPool>* <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> *\<PathToCollectionPlan>* *\<FullPathToITraceFileDirectory>*  
  
    > [!IMPORTANT]
    >  After you run this command, type **Y** to confirm that you want to start collecting data.  
  
     For example, to collect data from a SharePoint application in the **SharePoint - 80** application pool:  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |*ApplicationPool*|The name of the application pool where your application runs|  
    |*PathToCollectionPlan*|The path to a collection plan, an .xml file that configures settings for the collector.\<br />\<br /> You can specify a plan that comes with the collector. The following plans work for Web apps and SharePoint applications:\<br />\<br /> -   collection_plan.ASP.NET.default.xml\<br />     Collects only IntelliTrace events and SharePoint events, including exceptions, database calls, and Web server requests.\<br />-   collection_plan.ASP.NET.trace.xml\<br />     Collects function calls and all the data in collection_plan.ASP.NET.default.xml. This plan is good for detailed analysis, but it might slow down your app more than collection_plan.ASP.NET.default.xml.\<br />\<br /> To avoid slowing down your app, customize these plans or create your own plan. For security, put any custom plans in the same secure location as the collector files. See [Creating and Customizing IntelliTrace Collection Plans](http://go.microsoft.com/fwlink/?LinkId=227871) and [How can I get the most data without slowing down my app?](#Minimizing) **Note:**  By default, the max size of the .iTrace file is 100 MB. When the .iTrace file reaches this limit, the collector deletes the file’s earliest entries to make space for newer entries. To change this limit, edit the collection plan’s <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute. \<br />\<br /> *Where can I find localized versions of these collection plans?*\<br />\<br /> You can find localized plans in the collector's subfolders.|  
    |*FullPathToITraceFileDirectory*|The full path to the .iTrace file directory. **Security Note:**  Provide the full path, not a relative path.|  
  
     The collector attaches to the application pool and starts collecting data.  
  
     *Can I open the .iTrace file at this time?* No, the file is locked during data collection.  
  
2.  Reproduce the problem.  
  
3.  To take a snapshot of the .iTrace file, use this syntax:  
  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> *\<ApplicationPool>* <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
4.  To check collection status, use this syntax:  
  
     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
5.  To stop collecting data, use this syntax:  
  
     <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> *\<ApplicationPool>* <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
    > [!IMPORTANT]
    >  After you run this command, type **Y** to confirm that you want to stop collecting data. Otherwise, the collector might continue collecting data, the iTrace file will remain locked, or the file might not contain any useful data.  
  
6.  [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)  
  
##  \<a name="BKMK_Collect_Data_from_Executables">\</a> Collect data from a managed app  
  
1.  To start your app and collect data at the same time, use this syntax:  
  
     *\<FullPathToIntelliTraceCollectorExecutable>* <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> *\<PathToCollectionPlan>* <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> *\<FullPathToITraceFileDirectoryAndFileName>* *\<PathToAppExecutableFileAndFileName>*  
  
     For example, to collect data from an app named **MyApp**:  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |*FullPathToIntelliTraceCollectorExecutable*|The full path to the collector executable, IntelliTraceSC.exe|  
    |*PathToCollectionPlan*|The path to a collection plan, an .xml file that configures settings for the collector.\<br />\<br /> You can specify a plan that comes with the collector. The following plans work for managed apps:\<br />\<br /> -   collection_plan.ASP.NET.default.xml\<br />     Collects IntelliTrace events only, including exceptions, database calls, and Web server requests.\<br />-   collection_plan.ASP.NET.trace.xml\<br />     Collects function calls and all the data in collection_plan.ASP.NET.default.xml. This plan is good for detailed analysis, but it might slow down your app more than collection_plan.ASP.NET.default.xml.\<br />\<br /> To avoid slowing down your app, customize these plans or create your own plan. For security, put any custom plans in the same secure location as the collector files. See [Creating and Customizing IntelliTrace Collection Plans](http://go.microsoft.com/fwlink/?LinkId=227871) and [How can I get the most data without slowing down my app?](#Minimizing) **Note:**  By default, the max size of the .iTrace file is 100 MB. When the .iTrace file reaches this limit, the collector deletes the file’s earliest entries to make space for newer entries. To change this limit, edit the collection plan’s <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attribute. \<br />\<br /> *Where can I find localized versions of these collection plans?*\<br />\<br /> You can find localized plans in the collector's subfolders.|  
    |*FullPathToITraceFileDirectoryAndFileName*|The full path to the .iTrace file directory and the .iTrace file name with the **.itrace** extension. **Security Note:**  Provide the full path, not a relative path.|  
    |*PathToAppExecutableFileAndFileName*|The path and file name of your managed app|  
  
2.  Stop data collection by exiting the app.  
  
3.  [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)  
  
##  \<a name="BKMK_View_IntelliTrace_Log_Files">\</a> Open the .iTrace file in Visual Studio Enterprise  
  
> [!NOTE]
>  To debug with IntelliTrace and step through code, you must have the matching source files and symbol files. See [Set up your release to diagnose problems after deployment](../vs140/diagnose-problems-after-deployment.md).  
  
1.  Move the .iTrace file or copy it to a computer with Visual Studio Enterprise (but not Professional or Community editions).  
  
2.  Double-click the .iTrace file outside Visual Studio, or open the file from inside Visual Studio.  
  
     Visual Studio shows the **IntelliTrace Summary** page. In most sections, you can review events or other items, choose an item, and start debugging with IntelliTrace at the point where and when an event happened. See [Debug Your App with IntelliTrace Log Files](../vs140/using-saved-intellitrace-data.md).  
  
    > [!NOTE]
    >  To debug with IntelliTrace and step through code, you must have the matching source files and symbol files on your development machine. See [Set up your release to diagnose problems after deployment](../vs140/diagnose-problems-after-deployment.md).  
  
##  \<a name="Minimizing">\</a> How do I get the most data without slowing down my app?  
 IntelliTrace can collect lots of data, so the impact on your app's performance depends on the data that IntelliTrace collects and the kind of code it analyzes. See [Optimizing IntelliTrace Collection on Production Servers](http://go.microsoft.com/fwlink/?LinkId=255233).  
  
 Here are some ways to get the most data without slowing down your app:  
  
-   Run the collector only when you think there’s a problem, or when you can reproduce the problem.  
  
     Start collection, reproduce the problem, and then stop collection. Open the .iTrace file in Visual Studio Enterprise and examine the data. See [Open the IntelliTrace log file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files).  
  
-   For Web apps and SharePoint applications, the collector records data for every app that shares the specified application pool. This might slow down any app that shares the same application pool, even though you can only specify modules for a single app in a collection plan.  
  
     To prevent the collector from slowing down other apps, host each app in its own application pool.  
  
-   Review the events in the collection plan for which IntelliTrace collects data. Edit the collection plan to disable events that aren't relevant or don't interest you.  
  
     To disable an event, set the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> attribute for the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>:  
  
     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     If the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> attribute doesn't exist, the event is enabled.  
  
     *How does this improve performance?*  
  
    -   You can reduce startup time by disabling events that aren't relevant to the app. For example, disable Windows Workflow events for apps that don't use Windows Workflow.  
  
    -   You can improve both startup and runtime performance by disabling registry events for apps that access the registry but don't show problems with registry settings.  
  
-   Review the modules in the collection plan for which IntelliTrace collects data. Edit the collection plan to include only the modules that interest you:  
  
    1.  Open the collection plan. Find the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element.  
  
    2.  In <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, set the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
    3.  Use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> element to specify each module with one of the following: file name, string value to include any module whose name contains that string, or public key.  
  
     For example, to collect data from just the main Web module of the Fabrikam Fiber Web app, create a list like this one:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     To collect data from any module whose name includes "Fabrikam", create a list like this one:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     To collect data from modules by specifying their public key tokens, create a list like this one:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     *How does this improve performance?*  
  
     This reduces the amount of method call information and other instrumentation data that IntelliTrace collects when the app starts and runs. This data lets you:  
  
    -   Step through code after collecting the data.  
  
    -   Examine values passed to and returned from function calls.  
  
     *Why not exclude modules instead?*  
  
     By default, collection plans exclude modules by setting the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. However, excluding modules might still result in collecting data from modules that don't meet the list's criteria and might not interest you, such as third-party or open-source modules.  
  
-   *Is there any data that IntelliTrace doesn't collect?*  
  
     Yes, to reduce performance impact, IntelliTrace restricts data collection to values of primitive data types passed to and returned from methods and to values of primitive data types in fields on top-level objects passed to and returned from methods.  
  
     For example, suppose you have an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method signature that accepts an integer <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>:  
  
     <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
     The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> type has the following attributes: <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. An association relationship exists between <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> type.  
  
     ![Relationship between Employee and Address](../vs140/media/employeeaddressrelationship.png "EmployeeAddressRelationship")  
  
     The collector records values for <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object returned from the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> method. However, the collector doesn't record information about the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object other than whether it was null or not. The collector also doesn't record data about local variables in the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> method unless other methods use those local variables as parameters at which point they are recorded as method parameters.  
  
##  \<a name="WhereElse">\</a> Where else can I get IntelliTrace data?  
  
-   From an IntelliTrace debugging session in Visual Studio Enterprise, see [Record Execution History to Debug Your App with IntelliTrace in Visual Studio](../vs140/intellitrace-features.md).  
  
-   From a test session in Microsoft Test Manager, see [How to: Collect IntelliTrace Data to Help Debug Difficult Issues](assetId:///02b6716f-569e-4961-938a-e790a0c74b5c).  
  
## Where can I get more information?  
 [Debug Your App with IntelliTrace Log Files](../vs140/using-saved-intellitrace-data.md)  
  
 [Debug Apps by Recording Execution History with IntelliTrace](../vs140/intellitrace.md)  
  
### Blogs  
 [Using the IntelliTrace Standalone Collector Remotely](http://go.microsoft.com/fwlink/?LinkId=262277)  
  
 [Creating and Customizing IntelliTrace Collection Plans](http://go.microsoft.com/fwlink/?LinkId=227871)  
  
 [Optimizing IntelliTrace Collection on Production Servers](http://go.microsoft.com/fwlink/?LinkId=255233)  
  
 [Visual Studio ALM + TFS Blog](http://go.microsoft.com/fwlink/?LinkID=201340)  
  
### Forums  
 [Visual Studio Debugger](http://go.microsoft.com/fwlink/?LinkId=262263)  
  
### Videos  
 [Channel 9 video: Collecting and analyzing IntelliTrace data](http://go.microsoft.com/fwlink/?LinkID=251851)