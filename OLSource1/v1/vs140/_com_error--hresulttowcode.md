---
title: "_com_error::HRESULTToWCode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - HRESULTToWCode
  - _com_error.HRESULTToWCode
  - _com_error::HRESULTToWCode
dev_langs: 
  - C++
helpviewer_keywords: 
  - HRESULTToWCode method
ms.assetid: ff3789f5-1047-41a0-b7e3-86dd8f638dba
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _com_error::HRESULTToWCode
**Microsoft Specific**  
  
 Maps 32-bit `HRESULT` to 16-bit `wCode`.  
  
## Syntax  
  
```  
  
      static WORD HRESULTToWCode(  
   HRESULT hr   
) throw( );  
```  
  
#### Parameters  
 `hr`  
 The 32-bit `HRESULT` to be mapped to 16-bit `wCode`.  
  
## Return Value  
 16-bit `wCode` mapped from the 32-bit `HRESULT`.  
  
## Remarks  
 See [_com_error::WCode](../vs140/_com_error--wcode.md) for more information.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_error::WCode](../vs140/_com_error--wcode.md)   
 [_com_error::WCodeToHRESULT](../vs140/_com_error--wcodetohresult.md)   
 [_com_error Class](../vs140/_com_error-class.md)