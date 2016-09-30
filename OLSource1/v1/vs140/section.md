---
title: "section"
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
  - "section_CPP"
  - "vc-pragma.section"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, section"
  - "section pragma"
ms.assetid: c67215e9-2c4a-4b0f-b691-2414d2e2d96f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# section
Creates a section in an .obj file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The meaning of the terms *segment* and *section* are interchangeable in this topic.  
  
 Once a section is defined, it remains valid for the remainder of the compilation. However, you must use [__declspec(allocate)](../vs140/allocate.md) or nothing will be placed in the section.  
  
 *section-name* is a required parameter that will be the name of the section. The name must not conflict with any standard section names. See [/SECTION](../vs140/-section--specify-section-attributes-.md) for a list of names you should not use when creating a section.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is an optional parameter consisting of one or more comma-separated attributes that you want to assign to the section. Possible <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are:  
  
 **read**  
 Allows read operations on data.  
  
 **write**  
 Allows write operations on data.  
  
 **execute**  
 Allows code to be executed.  
  
 **shared**  
 Shares the section among all processes that load the image.  
  
 **nopage**  
 Marks the section as not pageable; useful for Win32 device drivers.  
  
 **nocache**  
 Marks the section as not cacheable; useful for Win32 device drivers.  
  
 **discard**  
 Marks the section as discardable; useful for Win32 device drivers.  
  
 **remove**  
 Marks the section as not memory-resident; virtual device drivers (V*x*D) only.  
  
 If you do not specify attributes, the section will have read and write attributes.  
  
## Example  
 In the following example, the first instruction identifies the section and its attributes. The integer <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not put into <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> because it was not declared with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> goes into the data section. The integer <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does go into <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as a result of its <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> storage-class attribute.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)