---
title: "Installing an Isolated Shell Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Shell [Visual Studio], deploying shell-based applications"
  - "Visual Studio shell, deploying shell-based applications"
ms.assetid: 33416226-9083-41b5-b153-10d2bf35c012
caps.latest.revision: 44
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Installing an Isolated Shell Application
To install a Shell app you must perform the following steps.  
  
-   Prepare your solution.  
  
-   Create a Windows Installer (MSI) package for your application.  
  
-   Create a Setup bootstrapper.  
  
 All of the example code in this document comes from the [Shell Deployment Sample](http://go.microsoft.com/fwlink/?LinkId=262245), which you can download from the Code Gallery on the MSDN website. The sample shows the results of performing each of these steps.  
  
## Prerequisites  
 To perform the procedures that this topic describes, the following tools must be installed on your computer.  
  
-   The Visual Studio SDK  
  
-   The [Windows Installer XML Toolset](http://go.microsoft.com/fwlink/?LinkId=82720) version 3.6  
  
 The sample also requires the Microsoft Visualization and Modeling SDK, which not all shells require.  
  
## Preparing Your Solution  
 By default, Shell templates build to VSIX packages, but this behavior is intended primarily for debugging purposes. When you deploy a Shell application, you must use MSI packages to allow for registry access and for restarts during installation. To prepare your application for MSI deployment, perform the following steps.  
  
#### To prepare a Shell application for MSI deployment  
  
1.  Edit each .vsixmanifest file in your solution.  
  
     In the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element, add an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element and a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element, and then set their values to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
     These elements prevent the VSIX installer from trying to install your components and the user from uninstalling them by using the **Extensions and Updates** dialog box.  
  
2.  For each project that contains a VSIX manifest, edit the build tasks to output the content to the location from which your MSI will install. Include the VSIX manifest in the build output, but don't build a .vsix file.  
  
## Creating an MSI for Your Shell  
 To build your MSI package, we recommend that you use the [Windows Installer XML Toolset](http://go.microsoft.com/fwlink/?LinkId=82720) because it gives greater flexibility than a standard Setup project.  
  
 In your Product.wxs file, set detection blocks and the layout of Shell components.  
  
 Then create Registry entries, both in the .reg file for your solution and in ApplicationRegistry.wxs.  
  
### Detection Blocks  
 A detection block consists of a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element that specifies a prerequisite to detect and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element that specifies a message to return if the prerequisite isn't present on the computer. For example, your Shell application will require the Microsoft Visual Studio Shell redistributable, and the detection block will resemble the following markup.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Layout of Shell Components  
 You must add elements to identify the target directory structure and the components to install.  
  
##### To set the layout of Shell components  
  
1.  Create a hierarchy of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements to represent all of the directories to create on the file system on the target computer, as the following example shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     These directories are referred to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> when files that must be installed are specified.  
  
2.  Identify the components that the Shell and your Shell application require, as the following example shows.  
  
    > [!NOTE]
    >  Some elements may refer to definitions in other .wxs files.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
    1.  The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element refers to another .wxs file that identifies files that the current component requires. For example, GeneralProfile has the following definition in HelpAbout.wxs.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
         The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element specifies where these files go on the user's computer. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element specifies that it will be installed into a sub-directory, and each <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element represents a file that's built or that exists as part of the solution and identifies where that file can be found when the MSI file is created.  
  
    2.  The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element refers to a group of other components (or components and component groups). For instance, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> under ApplicationGroup is defined as follows in Application.wxs.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  Required dependencies for Shell (Isolated) applications are: DebuggerProxy, MasterPkgDef, Resources (especially the .winprf file), Application, and PkgDefs.  
  
### Registry Entries  
 The Shell (Isolated) project template includes a *ProjectName*.reg file for registry keys to merge on installation. These registry entries must be part of the MSI for both installation and cleanup purposes. You must also create matching registry blocks in ApplicationRegistry.wxs.  
  
##### To integrate registry entries into the MSI  
  
1.  In the **Shell Customization** folder, open *ProjectName*.reg.  
  
2.  Replace all instances of the $RootFolder$ token with the path of the target installation directory.  
  
3.  Add any other registry entries that your application requires.  
  
4.  Open ApplicationRegistry.wxs.  
  
5.  For each registry entry in *ProjectName*.reg, add a corresponding registry block, as the following examples show.  
  
    |*ProjectName*.reg|ApplicationRegisty.wxs|  
    |-----------------------|----------------------------|  
    |[HKEY_CLASSES_ROOT\CLSID\\{bb431796-a179-4df7-b65d-c0df6bda7cc6}]\<br />\<br /> @="PhotoStudio DTE Object"|\<RegistryKey Id='DteClsidRegKey' Root='HKCR' Key='$(var.DteClsidRegKey)' Action='createAndRemoveOnUninstall'>\<br />\<br /> \<RegistryValue Type='string' Name='@' Value='$(var.ShortProductName) DTE Object' />\<br />\<br /> \</RegistryKey>|  
    |[HKEY_CLASSES_ROOT\CLSID\\{bb431796-a179-4df7-b65d-c0df6bda7cc6}\LocalServer32]\<br />\<br /> @="$RootFolder$\PhotoStudio.exe"|\<RegistryKey Id='DteLocSrv32RegKey' Root='HKCR' Key='$(var.DteClsidRegKey)\LocalServer32' Action='createAndRemoveOnUninstall'>\<br />\<br /> \<RegistryValue Type='string' Name='@' Value='[INSTALLDIR]$(var.ShortProductName).exe' />\<br />\<br /> \</RegistryKey>|  
  
     In this example, Var.DteClsidRegKey resolves to the registry key in the top row. Var.ShortProductName resolves to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## Creating a Setup Bootstrapper  
 Your completed MSI will install only if all the prerequisites are installed first. To ease the end user experience, create a Setup program that gathers and installs all prerequisites before it installs your application. To ensure a successful installation, perform these actions:  
  
-   Enforce installation by Administrator.  
  
-   Detect whether the Visual Studio Shell (Isolated) is installed.  
  
-   Run one or both Shell installers in order.  
  
-   Handle restart requests.  
  
-   Run your MSI.  
  
### Enforcing Installation by Administrator  
 This procedure is required to enable the Setup program to access required directories such as \Program Files\\.  
  
##### To enforce installation by Administrator  
  
1.  Open the shortcut menu for the Setup project, and then choose **Properties**.  
  
2.  Under **Configuration Properties/Linker/Manifest File**, set **UAC Execution Level** to **requireAdministrator**.  
  
     This property puts the attribute that requires the program to be run as Administrator into the embedded manifest file.  
  
### Detecting Shell Installations  
 To determine whether the Visual Studio Shell (Isolated) must be installed, first determine whether it's already installed by checking the registry value of HKLM\Software\Microsoft\DevDiv\vs\Servicing\ShellVersion\isoshell\LCID\Install.  
  
> [!NOTE]
>  These values are also read by the Shell detection block in Product.wxs.  
  
 HKLM\Software\Microsoft\AppEnv\14.0\ShellFolder specifies the location where the Visual Studio Shell was installed, and you can check for files there.  
  
 For an example of how to detect a Shell installation, see the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function of Utilities.cpp in the Shell Deployment Sample.  
  
 If one or both of the Visual Studio Shells that your package requires isn't installed on the computer, you must add them to your list of components to install. For an example, see the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function of ComponentsPage.cpp in the Shell Deployment Sample.  
  
### Running the Shell Installers  
 To run the Shell installers, call the Visual Studio Shell redistributables by using the correct command-line arguments. At a minimum, you must use the command-line arguments **/norestart /q** and watch for the return code to determine what should be done next. The following example runs the Shell (Isolated) redistributable.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Running the Shell Language Pack Installers  
 If you instead find that the shell or shells have been installed and just need a language pack, you can install the language packs as the following example shows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Deciphering Return Values  
 On some operating systems, the Visual Studio Shell (Isolated) installation will require a restart. This condition can be determined by the return code of the call to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
|Return Value|Description|  
|------------------|-----------------|  
|ERROR_SUCCESS|Installation completed. You can now install your application.|  
|ERROR_SUCCESS_REBOOT_REQUIRED|Installation completed. You can install your application after the computer has been restarted.|  
|3015|Installation is in progress. A computer restart is required to continue the installation.|  
  
### Handling Restarts  
 When you ran the Shell installer by using the **/norestart** argument, you specified that it wouldn't restart the computer or ask for the computer to be restarted. However, a restart might be required, and you must ensure that your installer continues after the computer is restarted.  
  
 To handle restarts correctly, make sure that only one Setup program is set to resume and that the resume process will be handled correctly.  
  
 If either ERROR_SUCCESS_REBOOT_REQUIRED or 3015 is returned, your code should restart the computer before the installation continues.  
  
 To handle restarts, perform these actions:  
  
-   Set the registry to resume installation when Windows starts.  
  
-   Perform a double restart of the bootstrapper.  
  
-   Delete the Shell installer ResumeData key.  
  
-   Restart Windows.  
  
-   Reset the start path of the MSI.  
  
### Setting the Registry to Resume Setup When Windows Starts  
 The HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce\ registry key executes at system startup with administrative permissions and then is erased. HKEY_CURRENT_USER contains a similar key, but it runs as a normal user and isn't appropriate for installations. You can resume installation by putting a string value in the RunOnce key that calls your installer. However, we recommend that you call the installer by using a **/restart** or similar parameter to notify the application that it's resuming instead of starting. You can also include parameters to indicate where you are in the installation process, which is especially useful in installations that may require multiple restarts.  
  
 The following example shows a RunOnce registry key value for resuming an installation.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
### Installing Double Restart of Bootstrapper  
 If Setup is used directly from RunOnce, the desktop won't be able to load completely. To make the full user interface available, you must create another execution of Setup and end the RunOnce instance.  
  
 You must re-execute the Setup program so that it obtains the correct permissions, and you must give it enough information to know where you stopped before the restart, as the following example shows.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Deleting the Shell Installer ResumeData Key  
 The Shell installer sets the HKLM\Software\Microsoft\VisualStudio\14.0\Setup\ResumeData registry key with data to resume Setup after restart. Because your application, not the Shell installer, is resuming, delete that registry key, as the following example shows.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Restarting Windows  
 After you set the required registry keys, you can restart Windows. The following example invokes the restart commands for different Windows operating systems.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Resetting the Start Path of MSI  
 Before restart, the current directory is the location of your Setup program but, after restart, the location becomes the system32 directory. Your Setup program should reset the current directory before each MSI call, as the following example shows.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Running the Application MSI  
 After the Visual Studio Shell installer returns ERROR_SUCCESS, you can run the MSI for your application. Because your Setup program is providing the user interface, start your MSI in quiet mode (**/q**) and with logging (**/L**), as the following example shows.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [Walkthrough: A Basic Isolated Shell Custom Tool](../vs140/walkthrough--creating-a-basic-isolated-shell-application.md)