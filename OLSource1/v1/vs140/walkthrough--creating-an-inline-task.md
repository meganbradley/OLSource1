---
title: "Walkthrough: Creating an Inline Task"
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
  - "MSBuild, tasks"
ms.assetid: 438194cb-668c-41a9-a7e2-c118d14c1ea7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating an Inline Task
MSBuild tasks are typically created by compiling a class that implements the \<xref:Microsoft.Build.Framework.ITask*> interface. Starting with the .NET Framework version 4, you can create tasks inline in the project file. You do not have to create a separate assembly to host the task. For more information, see [MSBuild Inline Tasks](../vs140/msbuild-inline-tasks.md).  
  
 This walkthrough shows how to create and run these inline tasks:  
  
-   A task that has no input or output parameters.  
  
-   A task that has one input parameter and no output parameters.  
  
-   A task that has two input parameters, and one output parameter that returns an MSBuild property.  
  
-   A task that has two input parameters, and one output parameter that returns an MSBuild item.  
  
 To create and run the tasks, use Visual Studio and the **Visual Studio Command Prompt Window**, as follows:  
  
-   Create an MSBuild project file by using Visual Studio.  
  
-   Modify the project file in Visual Studio to create the inline task.  
  
-   Use the **Command Prompt Window** to build the project and examine the results.  
  
## Creating and Modifying an MSBuild Project  
 The Visual Studio project system is based on MSBuild. Therefore, you can create a build project file by using Visual Studio. In this section, you create a Visual C# project file. (You can create a Visual Basic project file instead. In the context of this tutorial, the difference between the two project files is minor.)  
  
#### To create and modify a project file  
  
1.  In Visual Studio, on the **File** menu, click **New** and then click **Project**.  
  
2.  In the **New Project** dialog box, select the Visual C# project type, and then select the **Windows Forms Application** template. In the **Name** box, type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Type a **Location** for the solution, for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Ensure that **Create directory for solution** is selected, **Add to Source Control** is cleared, and **Solution Name** is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
     Click **OK** to create the project file.  
  
3.  In **Solution Explorer**, right-click the InlineTasks project node, and then click **Unload Project**.  
  
4.  Right-click the project node again, and then click **Edit InlineTasks.csproj**.  
  
     The project file appears in the code editor.  
  
## Adding a Basic Hello Task  
 Now, add to the project file a basic task that displays the message "Hello, world!" Also add a default TestBuild target to invoke the task.  
  
#### To add a basic hello task  
  
1.  In the root <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> node, change the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.The resulting <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> node should resemble this example:  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
2.  Add the following inline task and target to the project file just before the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> tag.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Save the project file.  
  
 This code creates an inline task that is named Hello and has no parameters, references, or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statements. The Hello task contains just one line of code, which displays a hello message on the default logging device, typically the console window.  
  
### Running the Hello Task  
 Run MSBuild by using the **Command Prompt Window** to construct the Hello task and to process the TestBuild target that invokes it.  
  
##### To run the Hello task  
  
1.  Click **Start**, click **All Programs**, and then locate the **Visual Studio Tools** folder and click **Visual Studio Command Prompt**.  
  
2.  In the **Command Prompt Window**, locate the folder that contains the project file, in this case, D:\InlineTasks\InlineTasks\\.  
  
3.  Type **msbuild** without command switches, and then press ENTER. By default, this builds the InlineTasks.csproj file and processes the default target TestBuild, which invokes the Hello task.  
  
4.  Examine the output in the **Command Prompt Window**. You should see this line:  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  If you do not see the hello message, try saving the project file again and then run the Hello task.  
  
 By alternating between the code editor and the **Command Prompt Window**, you can change the project file and quickly see the results.  
  
## Defining the Echo Task  
 Create an inline task that accepts a string parameter and displays the string on the default logging device.  
  
#### To define the Echo task  
  
1.  In the code editor, replace the Hello task and TestBuild target by using the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  In the **Command Prompt Window**, type **msbuild** without command switches, and then press ENTER. By default, this processes the default target TestBuild, which invokes the Echo task.  
  
3.  Examine the output in the **Command Prompt Window**. You should see this line:  
  
     <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 This code defines an inline task that is named Echo and has just one required input parameter Text. By default, parameters are of type System.String. The value of the Text parameter is set when the TestBuild target invokes the Echo task.  
  
## Defining the Adder Task  
 Create an inline task that adds two integer parameters and emits their sum as an MSBuild property.  
  
#### To define the Adder task  
  
1.  In the code editor, replace the Echo task and TestBuild target by using the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  In the **Command Prompt Window**, type **msbuild** without command switches, and then press ENTER. By default, this processes the default target TestBuild, which invokes the Echo task.  
  
3.  Examine the output in the **Command Prompt Window**. You should see this line:  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 This code defines an inline task that is named Adder and has two required integer input parameters, A and B, and one integer output parameter, C. The Adder task adds the two input parameters and returns the sum in the output parameter. The sum is emitted as the MSBuild property <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The values of the input parameters are set when the TestBuild target invokes the Adder task.  
  
## Defining the RegX Task  
 Create an inline task that accepts an item group and a regular expression, and returns a list of all items that have file content that matches the expression.  
  
#### To define the RegX task  
  
1.  In the code editor, replace the Adder task and TestBuild target by using the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  In the **Command Prompt Window**, type **msbuild** without command switches, and then press ENTER. By default, this processes the default target TestBuild, which invokes the RegX task.  
  
3.  Examine the output in the **Command Prompt Window**. You should see these lines:  
  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 This code defines an inline task that is named RegX and has these three parameters:  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a required string input parameter that has a value that is the regular expression to be matched. In this example, the expression matches the words "public" or "protected".  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a required item list input parameter that has a value that is a list of files to be searched for the match. In this example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> item, which lists the project source files.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is an output parameter that has a value that is is the list of files that have contents that match the regular expression.  
  
 The value of the input parameters are set when the TestBuild target invokes the RegX task. The RegX task reads every file and returns the list of files that match the regular expression. This list is returned as the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> output parameter, which is emitted as the MSBuild item <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Handling Reserved Characters  
 The MSBuild parser processes inline tasks as XML. Characters that have reserved meaning in XML, for example, "\<" and ">", are detected and handled as if they were XML, and not .NET source code. To include the reserved characters in code expressions such as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, write the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element so that its contents are contained in a CDATA expression, as follows:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## See Also  
 [MSBuild Inline Tasks](../vs140/msbuild-inline-tasks.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)