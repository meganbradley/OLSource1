---
title: "CComVariant::ReadFromStream"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CComVariant::ReadFromStream
  - ReadFromStream
  - CComVariant::ReadFromStream
  - CComVariant.ReadFromStream
  - ATL.CComVariant.ReadFromStream
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReadFromStream method
ms.assetid: 36baa57f-8586-4199-bf9a-a0f23bd049e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComVariant::ReadFromStream
Sets the underlying **VARIANT** to the **VARIANT** contained in the specified stream.  
  
## Syntax  
  
```  
  
      HRESULT ReadFromStream(  
   IStream* pStream   
);  
```  
  
#### Parameters  
 `pStream`  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on the stream containing the data.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 **ReadToStream** requires a previous call to [WriteToStream](../vs140/ccomvariant--writetostream.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)