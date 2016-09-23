---
title: "AfxGetPerUserRegistration"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AfxGetPerUserRegistration
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxGetPerUserRegistration function
ms.assetid: 87c8536e-c9af-46e2-b2f2-f406c1fd12af
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxGetPerUserRegistration
Use this function to determine whether the application redirects registry access to the **HKEY_CURRENT_USER** (**HKCU**) node.  
  
## Syntax  
  
```  
BOOL AFXAPI AfxGetPerUserRegistration();  
```  
  
## Return Value  
 `TRUE` indicates that the registry information is directed to the **HKCU** node; `FALSE` indicates that the application writes registry information to the default node. The default node is **HKEY_CLASSES_ROOT** (**HKCR**).  
  
## Remarks  
 If you enable registry redirection, the framework redirects access from **HKCR** to **HKEY_CURRENT_USER\Software\Classes**. Only the MFC and ATL frameworks are affected by the redirection.  
  
 To change whether the application redirects registry access, use [AfxSetPerUserRegistration](../vs140/afxsetperuserregistration.md).  
  
## Requirements  
 `Header:` afxstat_.h  
  
## See Also  
 [Macros, Global Functions, and Global Variables](../vs140/macros--global-functions--and-global-variables.md)   
 [AfxSetPerUserRegistration](../vs140/afxsetperuserregistration.md)   
 [Application Information and Management](../vs140/application-information-and-management.md)