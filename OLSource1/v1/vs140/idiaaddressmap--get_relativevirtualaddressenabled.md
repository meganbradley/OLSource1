---
title: "IDiaAddressMap::get_relativeVirtualAddressEnabled"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaAddressMap::get_relativeVirtualAddressEnabled method"
ms.assetid: 4c48af81-7148-4d9a-818e-dbe62cbfc638
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaAddressMap::get_relativeVirtualAddressEnabled
Indicates whether the calculation and use of relative virtual addresses (RVA) is enabled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pRetVal  
 [out] Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the calculation of RVAs is enabled.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 RVAs are enabled if the segments have been initially loaded from a PDB file. The use of RVAs can be temporarily disabled by calling the [IDiaAddressMap::put_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--put_relativevirtualaddressenabled.md) method.  
  
 Also, new image headers can be established by calling the [IDiaAddressMap::set_imageHeaders](../vs140/idiaaddressmap--set_imageheaders.md) method followed by a call to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method to enable use of the RVAs using the new image headers.  
  
## See Also  
 [IDiaAddressMap](../vs140/idiaaddressmap.md)   
 [IDiaAddressMap::set_imageHeaders](../vs140/idiaaddressmap--set_imageheaders.md)   
 [IDiaAddressMap::put_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--put_relativevirtualaddressenabled.md)