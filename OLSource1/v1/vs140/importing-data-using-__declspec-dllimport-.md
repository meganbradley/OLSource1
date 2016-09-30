---
title: "Importing Data Using __declspec(dllimport)"
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
  - "dllimport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "importing data [C++]"
  - "dllimport attribute [C++], data imports"
  - "__declspec(dllimport) keyword [C++]"
  - "importing DLLs [C++], __declspec(dllimport)"
ms.assetid: 0ae70b39-87c7-4181-8be9-e786e0db60b0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Importing Data Using __declspec(dllimport)
In the case of data, using **__declspec(dllimport)** is a convenience item that removes a layer of indirection. When you import data from a DLL, you still have to go through the import address table. Before **__declspec(dllimport)**, this meant you had to remember to do an extra level of indirection when accessing data exported from the DLL:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You would then export the data in your .DEF file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 and access it outside the DLL:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When you mark the data as **__declspec(dllimport)**, the compiler automatically generates the indirection code for you. You no longer have to worry about the steps above. As stated previously, do not use **__declspec(dllimport)** declaration on the data when building the DLL. Functions within the DLL do not use the import address table to access the data object; therefore, you will not have the extra level of indirection present.  
  
 To export the data automatically from the DLL, use this declaration:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Importing into an Application](../vs140/importing-into-an-application.md)