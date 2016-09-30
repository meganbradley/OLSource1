---
title: "MSBuild Inline Tasks"
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
  - "MSBuild, tasks"
ms.assetid: e72e6506-4a11-4edf-ae8d-cfb5a3b9d8a0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Inline Tasks
MSBuild tasks are typically created by compiling a class that implements the \<xref:Microsoft.Build.Framework.ITask*> interface. For more information, see [MSBuild Tasks](../vs140/msbuild-tasks.md).  
  
 Starting in .NET Framework version 4, you can create tasks inline in the project file. You do not have to create a separate assembly to host the task. This makes it easier to keep track of source code and easier to deploy the task. The source code is integrated into the script.  
  
## The Structure of an Inline Task  
 An inline task is contained by a [UsingTask](../vs140/usingtask-element--msbuild-.md) element. The inline task and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element that contains it are typically included in a .targets file and imported into other project files as required. Here is a basic inline task. Notice that it does nothing.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element in the example has three attributes that describe the task and the inline task factory that compiles it.  
  
-   The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute names the task, in this case, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute names the class that implements the inline task factory.  
  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute gives the location of the inline task factory. Alternatively, you can use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute to specify the fully qualified name of the inline task factory class, which is typically located in the global assembly cache (GAC).  
  
 The remaining elements of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> task are empty and are provided to illustrate the order and structure of an inline task. A more robust example is presented later in this topic.  
  
-   The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element is optional. When specified, it declares the parameters for the task. For more information about input and output parameters, see "Input and Output Parameters" later in this topic.  
  
-   The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element describes and contains the task source code.  
  
-   The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element specifies references to the .NET assemblies that you are using in your code. This is equivalent to adding a reference to a project in Visual Studio. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute specifies the path of the referenced assembly.  
  
-   The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element lists the namespaces that you want to access. This resembles the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement in Visual C#. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute specifies the namespace to include.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements are language-agnostic. Inline tasks can be written in any one of the supported .NET CodeDom languages, for example, Visual Basic or Visual C#.  
  
> [!NOTE]
>  Elements contained by the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element are specific to the task factory, in this case, the code task factory.  
  
### Code Element  
 The last child element to appear within the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element is the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element contains or locates the code that you want to be compiled into a task. What you put in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> element depends on how you want to write the task.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attribute specifies the language in which your code is written. Acceptable values are <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for C#, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for Visual Basic.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attribute specifies the type of code that is found in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> element.  
  
-   If the value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, then the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> element contains code for a class that derives from the \<xref:Microsoft.Build.Framework.ITask*> interface.  
  
-   If the value of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, then the code defines an override of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method of the \<xref:Microsoft.Build.Framework.ITask*> interface.  
  
-   If the value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, then the code defines the contents of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method, but not the signature or the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> statement.  
  
 The code itself typically appears between a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> marker and a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> marker. Because the code is in a CDATA section, you do not have to worry about escaping reserved characters, for example, "\<" or ">".  
  
 Alternatively, you can use the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> element to specify the location of a file that contains the code for your task. The code in the source file must be of the type that is specified by the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> attribute. If the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute is present, the default value of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is not present, the default value is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When defining the task class in the source file, the class name must agree with the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute of the corresponding [UsingTask](../vs140/usingtask-element--msbuild-.md) element.  
  
## Hello World  
 Here is a more robust inline task. The HelloWorld task displays "Hello, world!" on the default error logging device, which is typically the system console or the Visual Studio **Output** window. The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element in the example is included just for illustration.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You could save the HelloWorld task in a file that is named HelloWorld.targets, and then invoke it from a project as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Input and Output Parameters  
 Inline task parameters are child elements of a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element. Every parameter takes the name of the element that defines it. The following code defines the parameter <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Parameters may have one or more of these attributes:  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is an optional attribute that is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> by default. If <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, then the parameter is required and must be given a value before calling the task.  
  
-   <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is an optional attribute that is <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> by default. It may be set to any fully qualified type that is either an item or a value that can be converted to and from a string by using System.Convert.ChangeType. (In other words, any type that can be passed to and from an external task.)  
  
-   <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is an optional attribute that is <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> by default. If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, then the parameter must be given a value before returning from the Execute method.  
  
 For example,  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 defines these three parameters:  
  
-   <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is a required input parameter of type System.String.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is a required item list input parameter.  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is an output parameter of type System.Int32.  
  
 If the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> element has the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> attribute of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, then properties are automatically created for every parameter. Otherwise, properties must be explicitly declared in the task source code, and must exactly match their parameter definitions.  
  
## Example  
 The following inline task replaces every occurrence of a token in the given file with the given value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [Walkthrough: Creating an Inline Task](../vs140/walkthrough--creating-an-inline-task.md)