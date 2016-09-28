---
title: "AfxDaoTerm"
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
  - "AfxDaoTerm"
  - "AFXDAO/AfxDaoTerm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database engine [C++], terminate"
  - "AfxDaoTerm function"
  - "DAO [C++], termination"
ms.assetid: 433ac1c3-1dc0-46be-b914-447838ed10b5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDaoTerm
This function terminates the DAO database engine.  
  
## Syntax  
  
```  
  
void AfxDaoTerm( );  
  
```  
  
## Remarks  
 Typically, you only need to call this function in a regular DLL; an application will automatically call `AfxDaoTerm` when it is needed.  
  
 In regular DLLs, call `AfxDaoTerm` before the `ExitInstance` function, but after all MFC DAO objects have been destroyed.  
  
 For related information, see [Technical Note 54](../vs140/tn054--calling-dao-directly-while-using-mfc-dao-classes.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxDaoInit](../vs140/afxdaoinit.md)