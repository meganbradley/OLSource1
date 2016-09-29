---
title: "AfxCheckError"
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
  - "AFXDISP/AfxCheckError"
  - "AfxCheckError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxCheckError function"
ms.assetid: 84738e07-075c-4227-9a9a-1de137b50f82
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxCheckError
This function tests the passed **SCODE** to see if it is an error.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxCheckError(  
   SCODE sc   
);  
throw CMemoryException*  
throw COleException*  
```  
  
## Remarks  
 If it is an error, the function throws an exception. If the passed `SCODE` is **E_OUTOFMEMORY**, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) by calling [AfxThrowMemoryException](../vs140/afxthrowmemoryexception.md). Otherwise, the function throws a [COleException](../vs140/coleexception-class.md) by calling [AfxThrowOleException](../vs140/afxthrowoleexception.md).  
  
 This function can be used to check the return values of calls to OLE functions in your application. By testing the return value with this function in your application, you can properly react to error conditions with a minimal amount of code.  
  
> [!NOTE]
>  This function has the same effect in debug and non-debug builds.  
  
## Example  
 [!code[NVC_MFCOleContainer#33](../vs140/codesnippet/CPP/afxcheckerror_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)