---
title: "How to: Use Build Events in MSBuild Projects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "msbuild.cpp.howto.usebuildevents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "msbuild (c++), howto: use build events in projects"
ms.assetid: 2a58dc9d-3d50-4e49-97c1-86c5a05ce218
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Build Events in MSBuild Projects
A build event is a command that [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] performs at a particular stage in the build process. The *pre-build* event occurs before the build starts; the *pre-link* event occurs before the link step starts; and the *post-build* event occurs after the build successfully ends. A build event occurs only if the associated build step occurs. For example, the pre-link event does not occur if the link step does not run.  
  
 Each of the three build events is represented in an item definition group by a command element (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) that is executed and a message element (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) that is displayed when **MSBuild** performs the build event. Each element is optional, and if you specify the same element multiple times, the last occurrence takes precedence.  
  
 An optional *use-in-build* element (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*build-event***UseInBuild**<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) can be specified in a property group to indicate whether the build event is executed. The value of the content of a *use-in-build* element is either <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. By default, a build event is executed unless its corresponding *use-in-build* element is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The following table lists each build event XML element:  
  
|XML Element|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|This event executes before the build begins.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|This event executes before the link step begins.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|This event executes after the build finishes.|  
  
 The following table lists each *use-in-build* element:  
  
|XML Element|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Specifies whether to execute the *pre-build* event.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Specifies whether to execute the *pre-link* event.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Specifies whether to execute the *post-build* event.|  
  
## Example  
 The following example can be added inside of the Project element of the myproject.vcxproj file created in [Walkthrough: Using MSBuild to Create a Visual C++ Project](../vs140/walkthrough--using-msbuild-to-create-a-visual-c---project.md). A *pre-build* event makes a copy of main.cpp; a *pre-link* event makes a copy of main.obj; and a *post-build* event makes a copy of myproject.exe. If the project is built using a release configuration, the build events are executed. If the project is built using a debug configuration, the build events are not executed.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild (Visual C++)](../vs140/msbuild--visual-c---.md)   
 [Walkthrough: Using MSBuild to Create a Visual C++ Project](../vs140/walkthrough--using-msbuild-to-create-a-visual-c---project.md)