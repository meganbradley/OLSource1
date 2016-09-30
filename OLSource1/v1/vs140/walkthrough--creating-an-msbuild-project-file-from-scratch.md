---
title: "Walkthrough: Creating an MSBuild Project File from Scratch"
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
  - "MSBuild, tutorial"
ms.assetid: e3acff7c-cb4e-4ae1-8be2-a871bcff847b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating an MSBuild Project File from Scratch
Programming languages that target the .NET Framework use MSBuild project files to describe and control the application build process. When you use Visual Studio to create an MSBuild project file, the appropriate XML is added to the file automatically. However, you may find it helpful to understand how the XML is organized and how you can change it to control a build.  
  
 For information about creating a project file for a C++ project, see [Walkthrough: Using MSBuild to Create a Visual C++ Project](../vs140/msbuild--visual-c---.md).  
  
 This walkthrough shows how to create a basic project file incrementally, by using only a text editor. The walkthrough follows these steps:  
  
-   Create a minimal application source file.  
  
-   Create a minimal MSBuild project file.  
  
-   Extend the PATH environment variable to include MSBuild.  
  
-   Build the application by using the project file.  
  
-   Add properties to control the build.  
  
-   Control the build by changing property values.  
  
-   Add targets to the build.  
  
-   Control the build by specifying targets.  
  
-   Build incrementally.  
  
 This walkthrough shows how to build the project at the command prompt and examine the results. For more information about MSBuild and how to run MSBuild at the command prompt, see [MSBuild Tutorial 1](../vs140/walkthrough--using-msbuild.md).  
  
 To complete the walkthrough, you must have the .NET Framework (version 2.0, 3.5, 4.0, or 4.5) installed because it includes MSBuild and the Visual C# compiler, which are required for the walkthrough.  
  
## Creating a Minimal Application  
 This section shows how to create a minimal Visual C# application source file by using a text editor.  
  
#### To create the minimal application  
  
1.  At the command prompt, browse to the folder where you want to create the application, for example, \My Documents\ or \Desktop\\.  
  
2.  Type **md HelloWorld** to create a subfolder named \HelloWorld\\.  
  
3.  Type **cd HelloWorld** to change to the new folder.  
  
4.  Start Notepad or another text editor, and then type the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  Save this source code file and name it Helloworld.cs.  
  
6.  Build the application by typing **csc helloworld.cs** at the command prompt.  
  
7.  Test the application by typing **helloworld** at the command prompt.  
  
     The **Hello, world!** message should be displayed.  
  
8.  Delete the application by typing **del helloworld.exe** at the command prompt.  
  
## Creating a Minimal MSBuild Project File  
 Now that you have a minimal application source file, you can create a minimal project file to build the application. This project file contains the following elements:  
  
-   The required root <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> node.  
  
-   An <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> node to contain item elements.  
  
-   An item element that refers to the application source file.  
  
-   A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> node to contain tasks that are required to build the application.  
  
-   A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element to start the Visual C# compiler to build the application.  
  
#### To create a minimal MSBuild project file  
  
1.  In the text editor, replace the existing text by using these two lines:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Insert this <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> node as a child element of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> node:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Notice that this <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> already contains an item element.  
  
3.  Add a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> node as a child element of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> node. Name the node <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Insert this task element as a child element of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> node:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  Save this project file and name it Helloworld.csproj.  
  
 Your minimal project file should resemble the following code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Tasks in the Build target are executed sequentially. In this case, the Visual C# compiler <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> task is the only task. It expects a list of source files to compile, and this is given by the value of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> item. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> item references just one source file, Helloworld.cs.  
  
> [!NOTE]
>  In the item element, you can use the asterisk wildcard character (*) to reference all files that have the .cs file name extension, as follows:  
>   
>  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
>   
>  However, we do not recommend the use of wildcard characters because it makes debugging and selective targeting more difficult if source files are added or deleted.  
  
## Extending the Path to Include MSBuild  
 Before you can access MSBuild, you must extend the PATH environment variable to include the .NET Framework folder.  
  
#### To add MSBuild to your path  
  
-   Starting in Visual Studio 2013, you can find MSBuild.exe in the MSBuild folder (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> on a 32-bit operating system, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> on a 64-bit operating system).  
  
     At the command prompt, type **set PATH=%PATH%;%ProgramFiles%\MSBuild** or **set PATH=%PATH%;%ProgramFiles(x86)%\MSBuild**.  
  
     Alternatively, if you have Visual Studio installed, you can use the **Visual Studio Command Prompt**, which has a path that includes the MSBuild folder.  
  
## Using the Project File to Build the Application  
 Now, to build the application, use the project file that you just created.  
  
#### To build the application  
  
1.  At the command prompt, type **msbuild helloworld.csproj /t:Build**.  
  
     This builds the Build target of the Helloworld project file by invoking the Visual C# compiler to create the Helloworld application.  
  
2.  Test the application by typing **helloworld**.  
  
     The **Hello, world!** message should be displayed.  
  
> [!NOTE]
>  You can see more details about the build by increasing the verbosity level. To set the verbosity level to "detailed", type either of these commands at the command prompt:  
>   
>  **msbuild helloworld.csproj /t:Build /verbosity:detailed**  
  
## Adding Build Properties  
 You can add build properties to the project file to further control the build. Now add these properties:  
  
-   An <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> property to specify the name of the application.  
  
-   An <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> property to specify a folder to contain the application.  
  
#### To add build properties  
  
1.  Delete the existing application by typing **del helloworld.exe** at the command prompt.  
  
2.  In the project file, insert this <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element just after the opening <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> element:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Add this task to the Build target, just before the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> task:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> task creates a folder that is named by the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> property, provided that no folder by that name currently exists.  
  
4.  Add this <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> attribute to the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> task:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     This instructs the Visual C# compiler to produce an assembly that is named by the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> property and to put it in the folder that is named by the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> property.  
  
5.  Save your changes.  
  
 Your project file should now resemble the following code:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
> [!NOTE]
>  We recommend that you add the backslash (\\) path delimiter at the end of the folder name when you specify it in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> element, instead of adding it in the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> task. Therefore,  
>   
>  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
>   
>  <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
>   
>  is better than  
>   
>  <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
>   
>  <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
## Testing the Build Properties  
 Now you can build the application by using the project file in which you used build properties to specify the output folder and application name.  
  
#### To test the build properties  
  
1.  At the command prompt, type **msbuild helloworld.csproj /t:Build**.  
  
     This creates the \Bin\ folder and then invokes the Visual C# compiler to create the MSBuildSample application and puts it in the \Bin\ folder.  
  
2.  To verify that the \Bin\ folder has been created, and that it contains the MSBuildSample application, type **dir Bin**.  
  
3.  Test the application by typing **Bin\MSBuildSample**.  
  
     The **Hello, world!** message should be displayed.  
  
## Adding Build Targets  
 Next, add two more targets to the project file, as follows:  
  
-   A Clean target that deletes old files.  
  
-   A Rebuild target that uses the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> attribute to force the Clean task to run before the Build task.  
  
 Now that you have multiple targets, you can set the Build target as the default target.  
  
#### To add build targets  
  
1.  In the project file, add these two targets just after the Build target:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     The Clean target invokes the Delete task to delete the application. The Rebuild target does not run until both the Clean target and the Build target have run. Although the Rebuild target has no tasks, it causes the Clean target to run before the Build target.  
  
2.  Add this <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute to the opening <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     This sets the Build target as the default target.  
  
 Your project file should now resemble the following code:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## Testing the Build Targets  
 You can exercise the new build targets to test these features of the project file:  
  
-   Building the default build.  
  
-   Setting the application name at the command prompt.  
  
-   Deleting the application before another application is built.  
  
-   Deleting the application without building another application.  
  
#### To test the build targets  
  
1.  At the command prompt, type **msbuild helloworld.csproj /p:AssemblyName=Greetings**.  
  
     Because you did not use the **/t** switch to explicitly set the target, MSBuild runs the default Build target. The **/p** switch overrides the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> property and gives it the new value, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. This causes a new application, Greetings.exe, to be created in the \Bin\ folder.  
  
2.  To verify that the \Bin\ folder contains both the MSBuildSample application and the new Greetings application, type **dir Bin**.  
  
3.  Test the Greetings application by typing **Bin\Greetings**.  
  
     The **Hello, world!** message should be displayed.  
  
4.  Delete the MSBuildSample application by typing **msbuild helloworld.csproj /t:clean**.  
  
     This runs the Clean task to remove the application that has the default <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> property value, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
5.  Delete the Greetings application by typing **msbuild helloworld.csproj /t:clean /p:AssemblyName=Greetings**.  
  
     This runs the Clean task to remove the application that has the given **AssemblyName** property value, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
6.  To verify that the \Bin\ folder is now empty, type **dir Bin**.  
  
7.  Type **msbuild**.  
  
     Although a project file is not specified, MSBuild builds the helloworld.csproj file because there is only one project file in the current folder. This causes the MSBuildSample application to be created in the \Bin\ folder.  
  
     To verify that the \Bin\ folder contains the MSBuildSample application, type **dir Bin**.  
  
## Building Incrementally  
 You can tell MSBuild to build a target only if the source files or target files that the target depends on have changed. MSBuild uses the time stamp of a file to determine whether it has changed.  
  
#### To build incrementally  
  
1.  In the project file, add these attributes to the opening Build target:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
     This specifies that the Build target depends on the input files that are specified in the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> item group, and that the output target is the application file.  
  
     The resulting Build target should resemble the following code:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
2.  Test the Build target by typing **msbuild /v:d** at the command prompt.  
  
     Remember that helloworld.csproj is the default project file, and that Build is the default target.  
  
     The **/v:d** switch specifies a verbose description for the build process.  
  
     These lines should be displayed:  
  
     **Skipping target "Build" because all output files are up-to-date with respect to the input files.**  
  
     **Input files: HelloWorld.cs**  
  
     **Output files: BinMSBuildSample.exe**  
  
     MSBuild skips the Build target because none of the source files have changed since the application was last built.  
  
## Example  
  
### Description  
 The following example shows a project file that compiles a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application and logs a message that contains the output file name.  
  
### Code  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Comments  
  
## Example  
  
### Description  
 The following example shows a project file that compiles a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] application and logs a message that contains the output file name.  
  
### Code  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## What's Next?  
 Visual Studio can automatically do much of the work that is shown in this walkthrough. To learn how to use Visual Studio to create, edit, build, and test MSBuild project files, see [Tutorial: How to Use MSBuild](../vs140/walkthrough--using-msbuild.md).  
  
## See Also  
 [MSBuild Overview](../vs140/msbuild.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)