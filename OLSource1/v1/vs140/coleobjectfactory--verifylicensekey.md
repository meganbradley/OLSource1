---
title: "COleObjectFactory::VerifyLicenseKey"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "VerifyLicenseKey"
  - "COleObjectFactory::VerifyLicenseKey"
  - "COleObjectFactory.VerifyLicenseKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VerifyLicenseKey method"
  - "COleObjectFactory class, operations"
ms.assetid: a08b6d1b-d0cb-4ad6-b5f1-91b9a077af28
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::VerifyLicenseKey
Verifies that the container is licensed to use the OLE control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> storing the container's version of the license string.  
  
## Return Value  
 Nonzero if the run-time license is valid; otherwise 0.  
  
## Remarks  
 The default version calls [GetLicenseKey](../vs140/coleobjectfactory--getlicensekey.md) to get a copy of the control's license string and compares it with the string in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the two strings match, the function returns a nonzero value; otherwise it returns 0.  
  
 You can override this function to provide customized verification of the license.  
  
 The function [VerifyUserLicense](../vs140/coleobjectfactory--verifyuserlicense.md) verifies the design-time license.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::VerifyUserLicense](../vs140/coleobjectfactory--verifyuserlicense.md)   
 [COleObjectFactory::GetLicenseKey](../vs140/coleobjectfactory--getlicensekey.md)