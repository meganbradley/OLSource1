---
title: "CComBSTR::LoadString"
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
  - "CComBSTR.LoadString"
  - "ATL::CComBSTR::LoadString"
  - "ATL.CComBSTR.LoadString"
  - "CComBSTR::LoadString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadString method"
ms.assetid: 34f81276-8e27-44d4-8c11-81f764b43f2c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::LoadString
Loads a string resource specified by `nID` and stores it in this object.  
  
## Syntax  
  
```  
  
      bool LoadString(  
   HINSTANCE hInst,  
   UINT nID   
) throw();  
bool LoadString(  
   UINT nID   
) throw();  
```  
  
#### Parameters  
 See [LoadString](http://msdn.microsoft.com/library/windows/desktop/ms647486) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **true** if the string is successfully loaded; otherwise, returns **false**.  
  
## Remarks  
 The first function loads the resource from the module identified by you via the `hInst` parameter. The second function loads the resource from the resource module associated with the [CComModule](../vs140/ccommodule-class.md)-derived object used in this project.  
  
## Example  
 [!code[NVC_ATL_Utilities#43](../vs140/codesnippet/CPP/ccombstr--loadstring_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [ATL and MFC String Conversion Macros](assetId:///6ffb16b0-df9e-4011-a105-f756c3caf3ba)