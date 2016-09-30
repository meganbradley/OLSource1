---
title: "Definitions and Declarations (C)"
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
  - "C"
helpviewer_keywords: 
  - "export functions"
ms.assetid: d150395a-89d4-4298-9ac4-08f84fe1261c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Definitions and Declarations (C)
**Microsoft Specific**  
  
 The DLL interface refers to all items (functions and data) that are known to be exported by some program in the system; that is, all items that are declared as **dllimport** or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. All declarations included in the DLL interface must specify either the **dllimport** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute. However, the definition can specify only the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute. For example, the following function definition generates a compiler error:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code also generates an error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, this is correct syntax:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> implies a definition, while **dllimport** implies a declaration. You must use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to force a declaration; otherwise, a definition is implied.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [DLL Import and Export Functions](../vs140/dll-import-and-export-functions.md)