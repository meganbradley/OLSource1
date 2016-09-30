---
title: "Configure the Visual Studio Tools for Apache Cordova"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 75e3ef0b-a08e-4db4-be7f-d0a6226229bc
caps.latest.revision: 56
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Configure the Visual Studio Tools for Apache Cordova
[!INCLUDE[cordova_header](../vs140/includes/cordova_header_md.md)]  
  
 Once you have [installed the tools](../vs140/install-visual-studio-tools-for-apache-cordova.md), refer to this topic for additional ways to quickly configure, update, or customize the tools for your environment.  
  
-   If you choose not to install one or more dependencies with Visual Studio Tools for Apache Cordova, you may need to [install the dependencies manually](#ThirdParty).  
  
-   If you need to verify the path for a third-party dependency or if you have multiple versions of a dependency installed, see [Override system environment variables](#env_var).  
  
-   If you are running Visual Studio behind a proxy, see [Configure tools to work with a proxy](#Proxy).  
  
-   To install, start, and configure the remotebuild agent (previously called vs-mda-remote) for building iOS apps, see the following:  
  
    -   [Install the remote agent and get it running](https://msdn.microsoft.com/library/dn757054\(v=vs.140\).aspx#ios) (external topic)  
  
    -   [Generate a new security PIN](#IosPin)  
  
    -   [Configure the remote agent](#IosConfig)  
  
    -   [Generate a new server certificate](#IosCert)  
  
    -   [Verify the remote agent configuration](#IosVerify)  
  
-   If you see unexpected errors when trying to build the Blank App template, see [Re-install vs-tac](https://msdn.microsoft.com/library/dn771551\(v=vs.140\).aspx#vstac).  
  
    > [!CAUTION]
    >  If you are migrating a project from an earlier version of Visual Studio, see this [migration information](https://github.com/Microsoft/cordova-docs/blob/master/known-issues/known-issues-vs2015.md#known-issues---visual-studio-2015) (github).  
  
-   For other issues not listed here, see the [Known Issues](http://go.microsoft.com/fwlink/p/?linkid=398782).  
  
##  \<a name="ThirdParty">\</a> Install dependencies manually  
 If you choose not to install one or more dependencies with the extension, you can install them later manually.  
  
 You can install the dependencies in any order, except for Java. You must install and configure Java before you install the Android SDK.  
  
 Read the following information and use these links to install dependencies manually.  
  
-   [Joyent Node.js](http://go.microsoft.com/fwlink/?LinkID=396867)  
  
     We recommend installing the x86 version of Node.js.  
  
-   [Google Chrome](https://www.google.com/intl/en/chrome/browser/index.html)  
  
-   [Git Command Line Tools](http://go.microsoft.com/fwlink/?LinkID=396870)  
  
     When you install Git command line tools, select the option that adds Git to your command prompt path.  
  
    > [!CAUTION]
    >  Git command line tools 1.9.5 are installed by default. Unexpected failures may occur if you install a version prior to 1.9.0.  
  
-   [Apache Ant](http://go.microsoft.com/fwlink/?LinkID=396869)  
  
    -   Download and extract Ant to a location like C:/ant-1.x.x  
  
    -   Set the ANT_HOME environment variable to point to the preceding location.  
  
    -   Add %ANT_HOME%\bin to the system path.  
  
        > [!NOTE]
        >  If you need to set this environment variable manually, see [Override system environment variables](#env_var).  
  
-   [32-bit Oracle Java 7](http://go.microsoft.com/fwlink/?LinkID=396871)  
  
    -   Set the JAVA_HOME environment variable to C:/Program Files/Java/jdk1.7.0_55  
  
    -   Add this to the system path: %JAVA_HOME%\bin  
  
    -   To avoid out of memory issues, set a _JAVA_OPTIONS environment variable with at least -Xmx512M in it.  
  
        > [!NOTE]
        >  If you need to set this environment variable manually, see [Override system environment variables](#env_var).  
  
-   [Android SDK](http://go.microsoft.com/fwlink/?LinkID=396873) with the following SDK packages:  
  
    -   Android SDK Tools (latest version)  
  
    -   Android SDK Platform-tools (latest version)  
  
    -   Android SDK Build-tools (19.1, 19.0.3, and 21)  
  
    -   Android 5.0 (API level 21) with the following packages:  
  
        -   SDK Platform  
  
        -   If you want to use the Google Android Emulator to emulate a 5.0.x device:  
  
            -   ARM EABI v7a System Image  
  
            -   Intel x86 Atom System Image  
  
            -   Google APIs (x86 System Image)  
  
            -   Google APIs (ARM System Image)  
  
    -   If you want to use Cordova 5.0.0 or later:  
  
        -   Android 5.1.x (API level 22) with the following packages:  
  
            -   SDK platform  
  
            -   If you want to use the Google Android Emulator to emulate a 5.1.x device:  
  
                -   ARM EABI v7a System Image  
  
                -   Intel x86 Atom System Image  
  
                -   Google APIs (x86 System Image)  
  
                -   Google APIs (ARM System Image)  
  
     The following illustration shows the minimum required packages in the Android SDK Manager.  
  
     ![Cordova&#95;SDK&#95;Android&#95;Packages](../vs140/media/cordova_sdk_android_packages.png "Cordova_SDK_Android_Packages")  
  
     Set the ADT_HOME environment variable to the SDK installation location.  
  
     Add this to the system path: %ADT_HOME%tools;%ADT_HOME%platform-tools  
  
     If you need to set this environment variable manually, see [Override system environment variables](#env_var).  
  
    > [!TIP]
    >  If you install the Android SDK to its default location on Windows, it gets installed to C:Program Files (x86)Androidandroid-sdk.  
  
-   Apple iTunes ([x86](http://go.microsoft.com/fwlink/?LinkID=397715), [x64](http://go.microsoft.com/fwlink/?LinkID=397313))  
  
-   **WebSocket4Net** (required if you’re developing your app on Windows 7)  
  
    1.  Download WebSocket4Net(0.9).Binaries.zip from [CodePlex](http://go.microsoft.com/fwlink/?LinkID=403031).  
  
    2.  Unzip the binaries and then unblock net45\Release\WebSocket4Net.dll  
  
         To unblock the DLL, open the file Properties for the DLL and choose **Unblock** in the General tab (at the bottom of the dialog box).  
  
    3.  After you unblock the DLL, copy net45\Release\WebSocket4Net.dll into the %ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\WebClient\Diagnostics\ToolWindows folder on your computer.  
  
##  \<a name="env_var">\</a> Override system environment variables  
 Visual Studio detects the configurations for the third-party software you’ve installed, and maintains the installation paths in the following environment variables:  
  
-   **ADT_HOME** points to the Android installation path.  
  
-   **ANT_HOME** points to the Ant folder on your computer.  
  
-   **GIT_HOME** points to the Git installation path.  
  
-   **JAVA_HOME** points to the Java installation path.  
  
 Visual Studio uses these environment variables when building and running your app. You can view the environment variables and revise their values through the Visual Studio **Options** dialog box. You might want to override the default settings for one of the following reasons:  
  
-   Visual Studio was unable to verify the path. In this case, a warning is displayed next to the environment variable.  
  
-   You have multiple versions of the software installed, and you’d like to use a specific version.  
  
-   You want your global environment path to be different from the local Visual Studio environment.  
  
#### To override the variables  
  
1.  On the Visual Studio menu bar, choose **Tools**, **Options**.  
  
2.  In the **Options** dialog box, choose **Tools for Apache Cordova**, and then choose **Environment Variable Overrides**.  
  
3.  Make your changes:  
  
    -   To override a value, select its check box, and then revise the value.  
  
         If the path information is invalid or missing, Visual Studio displays a warning next to that variable.  
  
    -   To reset an environment variable to its default value, clear its check box or choose **Reset to Default**.  
  
4.  Choose **OK** to save your changes and close the dialog box.  
  
 ![Environment variables, warning message](../vs140/media/cordova_env_var_warning.png "Cordova_Env_Var_Warning")  
  
##  \<a name="IosPin">\</a> Generate a new security PIN (iOS remote agent)  
 When you [start the agent](https://msdn.microsoft.com/library/dn757054\(v=vs.140\).aspx#ios) the first time, the generated PIN is valid for a limited amount of time (10 minutes by default). If you don't connect to the agent before the time expires, or if you want to connect a second client to the agent, you will need to generate a new PIN.  
  
#### To generate a new security PIN  
  
1.  Stop the agent (or open a second Terminal app window on your Mac and use that to enter the command).  
  
2.  From the Terminal app on your Mac, type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The preceding command has changed in the latest version of the remotebuild agent. Use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to view the supported commands.  
  
3.  Follow instructions to [start the agent](https://msdn.microsoft.com/library/dn757054\(v=vs.140\).aspx#ios) on your Mac and configure the agent in Visual Studio.  
  
##  \<a name="IosCert">\</a> Generate a new server certificate (iOS remote agent)  
 For security purposes, the server certificates that pair Visual Studio with the remote agent are tied to your Mac’s IP or host name. If these values have changed, you will need to generate a new server certificate, and then reconfigure Visual Studio with the new values.  
  
#### To generate a new server certificate  
  
1.  Stop the agent.  
  
2.  From the Terminal app on your Mac, type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  When prompted, type "Y" and then type Enter.  
  
4.  From the Terminal app on your Mac, type:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     --hostname is optional. If omitted, the agent will attempt to determine the hostname automatically.  
  
5.  Follow instructions to [start the agent](https://msdn.microsoft.com/library/dn757054\(v=vs.140\).aspx#ios) on your Mac and configure the agent in Visual Studio.  
  
##  \<a name="IosConfig">\</a> Configure the iOS remote agent  
 You can configure the remote agent using various command line options. For example, you can specify the port to listen for build requests and specify the maximum number of builds to maintain on the file system. (By default, the limit is 10. The agent will remove builds that exceed the maximum on shutdown.)  
  
> [!CAUTION]
>  Many options have changed between vs-mda-remote and remotebuild.  
  
#### To configure the remote agent  
  
-   To see a complete list of agent commands, type:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   To disable secure mode and enable simple HTTP based connections, type:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     When you use this option, leave the PIN field blank and make sure to set **Secure Mode** to **False** when configuring the agent in Visual Studio.  
  
-   To specify a location for remote agent files, type:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     where *\<directory>* is a location on your Mac where log files, builds, and server certificates will be placed. For example, the location could be /Users/*username*/builds. (Builds will be organized by build number in this location.)  
  
-   To use a background process to capture <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to a file (server.log), type:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     The server.log file might assist in troubleshooting build issues.  
  
-   To run the agent by using a configuration file instead of command-line parameters, type:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     The configuration file must be in JSON format. The startup options and their values must not include dashes. To see a documented configuration file, look at the remotebuild/examples/exampleConfig.json folder in the remote agent installation directory, although you must remove the comments in the file that you use for your configuration. An example of a path you might use when running this command is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The default path where the agent looks for a configuration file is ~/.taco_home/RemoteBuild.config.  
  
##  \<a name="IosVerify">\</a> Verify the iOS remote agent configuration  
 Once you have [installed the agent](https://msdn.microsoft.com/library/dn757054\(v=vs.140\).aspx#ios), you can verify the remote agent configuration.  
  
#### To verify the remote agent configuration  
  
-   With the remote agent running, open a second Terminal app window (choose **Shell**, **New Window**).  
  
-   From the second Terminal app window on your Mac, type:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
    > [!IMPORTANT]
    >  This command will fail if the agent is not running in a second window, or if the two instances are not using the same configuration options.  
  
     This command initiates a test build. The output from the command should show the build number and other information about the build, such as its progress.  
  
     After you start a test build, [verify the build](#VerifyBuild).  
  
-   If you started the server on a port other than 3000, use the following command instead to initiate a test build:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   To verify that your developer signing identity is set up correctly for device builds (using the Debug and Release configurations in Visual Studio), type:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
-   To verify that your distribution signing identity is set up correctly for device builds (using the Debug configuration in Visual Studio), type:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     For more information about app provisioning and certificate signing identities, see [Package and Publish your app](../vs140/package-your-app-built-with-visual-studio-tools-for-apache-cordova.md).  
  
##  \<a name="vstac">\</a> Reinstall vs-tac  
 If you see unexpected errors when trying to build the Blank App template after installing Visual Studio Tools for Apache Cordova, you can try clearing your cache and reinstalling the Cordova CLI pre-processor, vs-tac, on your PC. Typically, this is only necessary if you try to build a Cordova app and see the error <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
#### To clear the cache  
  
1.  Choose **Tools**, **Options**, **Tools for Apache Cordova**, and then choose **Cordova Tools**.  
  
2.  Choose **Clear Cordova Cache**.  
  
3.  Close and re-open your project.  
  
4.  Choose **Build**, **Clean Solution**, and then rebuild your project.  
  
    > [!TIP]
    >  If you have no errors, you do not need to re-install vs-tac. If you still have the same error, then re-install vs-tac.  
  
#### To re-install vs-tac  
  
1.  Close Visual Studio.  
  
2.  Open a command line and type the following command:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     The default path to vs-tac is C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\Extensions\ApacheCordovaTools\packages\vs-tac  
  
3.  Re-open Visual Studio.  
  
4.  Open your project, choose **Build**, **Clean Solution**, and then rebuild your project.  
  
5.  If this does not resolve the issue, delete the platforms folder and re-try.  
  
     If the issue persists, see [Known Issues](http://go.microsoft.com/fwlink/p/?linkid=398782) for additional information.  
  
##  \<a name="Proxy">\</a> Configure tools to work with a proxy  
 If you are using Visual Studio behind a proxy, such as a corporate firewall, you may need to configure proxy settings for the npm package manager and for git before you can use Visual Studio Tools for Apache Cordova.  
  
> [!IMPORTANT]
>  Using npm proxy settings with recent versions of Node.js can cause Cordova to fail to acquire plugins at the command line or in the configuration designer or when adding platforms required for build. If you encounter unexpected issues (particularly a “TypeError: Request path contains unescaped characters” error), try downgrading Node.js to 0.10.29.  
  
#### To configure proxy settings for npm package manager  
  
1.  Close Visual Studio  
  
2.  Open a Visual Studio developer command window (Ctrl + Alt + A) and type the following command.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
3.  Open %AppData%\npm\node_modules and verify that the vs-tac folder has been removed.  
  
4.  In the Visual Studio developer command window, type the following command.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
     where *proxy-port* is the proxy address and port number, such as http://proxy.mycompany.com:80/  
  
5.  Then type this command:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
     where *proxy-port* might be a value such as http://proxy.mycompany.com:80/.  
  
6.  Open Visual Studio.  
  
7.  Open your Apache Cordova solution and rebuild your project.  
  
#### To configure proxy settings for git  
  
1.  Close Visual Studio.  
  
2.  Open a Visual Studio developer command window (Ctrl + Alt + A) and type the following command.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     where *username* and *password* are your proxy username and password; *proxy-port* might be a value such as proxy.mycompany.com:80  
  
3.  Type this command:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     where *username* and *password* are your proxy username and password; *proxy-port* might be a value such as proxy.mycompany.com:80  
  
4.  Open Visual Studio.  
  
5.  Open your Apache Cordova solution and rebuild your project.  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)  
  
## See Also  
 [Install the Visual Studio Tools for Apache Cordova Extension](../vs140/install-visual-studio-tools-for-apache-cordova.md)   
 [Run your App on iOS](../vs140/run-your-apache-cordova-app-on-ios.md)