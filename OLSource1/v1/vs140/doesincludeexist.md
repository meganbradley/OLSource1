---
title: "DoesIncludeExist"
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
  - "DoesIncludeExist"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesIncludeExist method"
ms.assetid: 39751a3d-dfe5-423c-bd94-a53771c3e360
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DoesIncludeExist
Indicates whether a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement for a specified header file exists in a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The selected project.  
  
 *strHeaderFile*  
 The name of the header file to find.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source file containing the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement for the header file (excluding the path).  
  
## Return Value  
 **true** if the specified header file is included; otherwise **false**.  
  
## Remarks  
 Indicates whether a #include for a specific header file exists in the file specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)