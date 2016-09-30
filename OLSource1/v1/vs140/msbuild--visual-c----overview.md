---
title: "MSBuild (Visual C++) Overview"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MSBuild overview"
ms.assetid: dd258f6f-ab51-48d9-b274-f7ba911d05ca
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild (Visual C++) Overview
MSBuild is the standard build system for Visual C++ projects. When you build a project in the Visual Studio integrated development environment (IDE), it uses the msbuild.exe tool, an XML-based project file, and optional settings files. Although you can use msbuild.exe and a project file on the command line, the IDE provides a user interface so that you can more easily configure settings and build a project. This overview describes how Visual C++ uses the MSBuild system.  
  
## Prerequisites  
 Read the following documents about MSBuild.  
  
 [MSBuild](../vs140/msbuild.md)  
 Overview of MSBuild concepts.  
  
 [MSBuild Reference](../vs140/msbuild-reference.md)  
 Reference information about the MSBuild system.  
  
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)  
 Lists the MSBuild XML Schema elements, together with their attributes, and parent and child elements. Especially note the [ItemGroup](../vs140/itemgroup-element--msbuild-.md), [PropertyGroup](../vs140/propertygroup-element--msbuild-.md), [Target](../vs140/target-element--msbuild-.md), and [Task](../vs140/task-element--msbuild-.md) elements.  
  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)  
 Describes the command-line arguments and options that you can use with msbuild.exe.  
  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)  
 Describes MSBuild tasks. Especially note these tasks, which are specific to Visual C++: [BscMake Task](../vs140/bscmake-task.md), [CL Task](../vs140/cl-task.md), [CPPClean Task](../vs140/cppclean-task.md), [LIB Task](../vs140/lib-task.md), [Link Task](../vs140/link-task.md), [MIDL Task](../vs140/midl-task.md), [MT Task](../vs140/mt-task.md), [RC Task](../vs140/rc-task.md), [SetEnv Task](../vs140/setenv-task.md), [VCMessage Task](../vs140/vcmessage-task.md), [XDCMake Task](../vs140/xdcmake-task.md), [XSD Task](../vs140/xsd-task.md).  
  
## MSBuild on the Command Line  
 The following statement from the [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md) document illustrates that the msbuild.exe tool takes an implicit or explicit <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> argument (a .vcxproj file for Visual C++ projects) and zero or more command-line <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 **msbuild.exe [** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> **] [** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> **]**  
  
 Use the **/target** (or **/t**) and **/property** (or **/p**) command-line options to override properties and targets that are specified in the project file.  
  
 An essential function of the project file is to specify a *target*, which is a particular operation applied to your project, and the inputs and outputs that are required to perform that operation. A project file can specify one or more targets, which can include a default target.  
  
 Each target consists of a sequence of one or more *tasks*. Each task is represented by a .NET Framework class that contains one executable command. For example, the [CL task](../vs140/cl-task.md) contains the [cl.exe](../vs140/compiling-a-c-c---program.md) command.  
  
 A *task parameter* is a property of the class task and typically represents a command-line option of the executable command. For example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> task corresponds to the **/Os** and **/Ot** compiler options.  
  
 Additional task parameters support the MSBuild infrastructure. For example, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task parameter specifies a set of tasks that can be consumed by other tasks. For more information about MSBuild tasks, see [MSBuild Task Reference](../vs140/msbuild-task-reference.md).  
  
 Most tasks require inputs and outputs, such as file names, paths, and string, numeric, or Boolean parameters. For example, a common input is the name of a .cpp source file to compile. An important input parameter is a string that specifies the build configuration and platform, for example, "Debug&#124;Win32". Inputs and outputs are specified by one or more user-defined XML <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements contained in an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element.  
  
 A project file can also specify user-defined *properties* and *item-definition-group**items*. Properties and items form name/value pairs that can be used as variables in the build. The name component of a pair defines a *macro*, and the value component declares the *macro value*. A property macro is accessed by using $(*name*) notation, and an item macro is accessed by using %(*name*) notation.  
  
 Other XML elements in a project file can test macros, and then conditionally set the value of any macro or control the execution of the build. Macro names and literal strings can be concatenated to generate constructs such as a path and file name. On the command line, the **/property** option sets or overrides a project property. Items cannot be referenced on the command line.  
  
 The MSBuild system can conditionally execute a target before or after another target. Also, the system can build a target based on whether the files that the target consumes are newer than the files it emits.  
  
## MSBuild in the IDE  
 When you set project properties in the IDE and then save the project, Visual C++ writes the project settings to your project file. The project file contains settings that are unique to your project, but it does not contain all the settings that are required to build your project. The project file contains <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements that include a network of additional *support files.* The support files contain the remaining properties, targets, and settings that are required to build the project.  
  
 Most targets and properties in the support files exist solely to implement the build system. The following section discusses some useful targets and properties that you can specify on the MSBuild command line. To discover more targets and properties, explore the files in the support file directories.  
  
### Support File Directories  
 By default, the primary Visual C++ support files are located in the following directories.  
  
|Directory|Description|  
|---------------|-----------------|  
|*drive*:\Program Files\MSBuild\Microsoft.Cpp\v4.0\\*version*\|Contains the primary target files (.targets) and property files (.props) that are used by the targets. By default, the $(VCTargetsPath) macro references this directory.|  
|*drive*:\Program Files\MSBuild\Microsoft.Cpp\v4.0\\*version*\Platforms\\*platform*\|Contains platform-specific target and property files that override targets and properties in its parent directory. This directory also contains a .dll file that defines the tasks that are used by the targets in this directory.\<br />\<br /> The *platform* placeholder represents the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> subdirectory.|  
|*drive*:\Program Files\MSBuild\Microsoft.Cpp\v4.0\\*version*\Platforms\\*platform*\PlatformToolsets\\*toolset*\|Contains the directories that enable the build to generate Visual C++ applications with the specified *version* of the toolset.\<br />\<br /> The *platform* placeholder represents the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> subdirectory. The *toolset* placeholder represents the toolset subdirectory for building Windows, Windows XP, or Windows Phone apps.|  
|*drive*:\Program Files\MSBuild\Microsoft.Cpp\v4.0\Platforms\\*platform*\PlatformToolsets\\*toolset*\|Contains the directories that enable the build to generate either 9.0 or Visual C++ 10.0 applications.\<br />\<br /> The *platform* placeholder represents the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> subdirectory. The *toolset* placeholder represents the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> toolset subdirectory.|  
  
### Support Files  
 The support file directories contain files with the following extensions.  
  
|Extension|Description|  
|---------------|-----------------|  
|.targets|Contains <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> XML elements that specify the tasks that are executed by the target. May also contain <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and user-defined <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> elements that are used to assign files and command-line options to task parameters.\<br />\<br /> For more information, see [Target Element (MSBuild)](../vs140/target-element--msbuild-.md).|  
|.props|Contains <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and user-defined <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> XML elements that specify file and parameter settings that are used during a build.\<br />\<br /> May also contain <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and user-defined <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> XML elements that specify additional settings. Items defined in an item definition group resemble properties, but cannot be accessed from the command line. Visual C++ project files frequently uses items instead of properties to represent settings.\<br />\<br /> For more information, see [ItemGroup Element (MSBuild)](../vs140/itemgroup-element--msbuild-.md), [ItemDefinitionGroup Element (MSBuild)](../vs140/itemdefinitiongroup-element--msbuild-.md), and [Item Element (MSBuild)](../vs140/item-element--msbuild-.md).|  
|.xml|Contains XML elements that declare and initialize IDE user interface elements such as property sheets and property pages, and text box and list box controls.\<br />\<br /> The .xml files directly support the IDE, not MSBuild. However, the values of IDE properties are assigned to build properties and items.\<br />\<br /> Most .xml files are in a locale-specific subdirectory. For example, files for the English-US region are in $(VCTargetsPath)\1033\\.|  
  
## User Targets and Properties  
 To use MSBuild most effectively on the command line, it helps to know which properties and targets are useful and relevant. Most properties and targets help implement the Visual C++ build system, and consequently are not relevant to the user. This section describes some worthwhile user-oriented properties and targets.  
  
### PlatformToolset Property  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> property determines which Visual C++ toolset is used in the build. The value of the property is concatenated with literal strings to form the path of a directory that contains the property and target files that are required to build a project for a particular platform.  
  
 Set the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to use [!INCLUDE[cpp_dev11_long](../vs140/includes/cpp_dev11_long_md.md)] tools and libraries to build your application.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 Set the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to use [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)] tools and libraries to build your application.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 Set the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to use Visual C++ 2008 tools and libraries to build your application. The Visual C++ 2008 toolset must already be installed on your computer for this property to be effective.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
### PreferredToolArchitecture Property  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> property determines whether the 32-bit or 64-bit compiler and tools are used in the build. This property does not affect the output platform architecture or configuration. By default, MSBuild uses the x86 version of the compiler and tools if this property is not set, or is set to any value other than <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 Set the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to use the 64-bit compiler and tools to build your application.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
### UseEnv Property  
 By default, the platform-specific settings for the current project override the PATH, INCLUDE, LIB, LIBPATH, CONFIGURATION, and PLATFORM environment variables. Set the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to guarantee that the environment variables are not overridden.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
### Targets  
 There are hundreds of targets in the Visual C++ support files. However, most are system-oriented targets that the user can ignore. Most system targets are prefixed by an underscore (_), or have a name that starts with "PrepareFor", "Compute", "Before", "After", "Pre", or "Post".  
  
 The following table lists several worthwhile user-oriented targets.  
  
|Target|Description|  
|------------|-----------------|  
|BscMake|Executes the Microsoft Browse Information Maintenance Utility tool, bscmake.exe.|  
|Build|Builds the project.\<br />\<br /> This is the default target for a project.|  
|ClCompile|Executes the Visual C++ compiler tool, cl.exe.|  
|Clean|Deletes temporary and intermediate build files.|  
|Lib|Executes the Microsoft 32-Bit Library Manager tool, lib.exe.|  
|Link|Executes the Visual C++ linker tool, link.exe.|  
|ManifestResourceCompile|Extracts a list of resources from a manifest and then executes the Microsoft Windows Resource Compiler tool, rc.exe.|  
|Midl|Executes the Microsoft Interface Definition Language (MIDL) compiler tool, midl.exe.|  
|Rebuild|Cleans and then builds your project.|  
|ResourceCompile|Executes the Microsoft Windows Resource Compiler tool, rc.exe.|  
|XdcMake|Executes the XML Documentation tool, xdcmake.exe.|  
|Xsd|Executes the XML Schema Definition tool, xsd.exe.|  
  
## See Also  
 [MSBuild (Visual C++)](../vs140/msbuild--visual-c---.md)