---
title: "IDiaAddressMap::set_addressMap"
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
  - "IDiaAddressMap::set_addressMap method"
ms.assetid: 81e82073-089b-43d5-af39-49d7a4907c7a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaAddressMap::set_addressMap
Provides an address map to support image layout translations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of elements in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of [DiaAddressMapEntry](../vs140/diaaddressmapentry.md) structures that define the translation map.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter defines a map from the new image layout to the original layout (as described by the debug symbols). <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a map to the new image layout taken from the original layout.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Usually, the DIA retrieves address translation maps from the program database (.pdb) file. If these values are missing, the [IDiaAddressMap::set_imageHeaders](../vs140/idiaaddressmap--set_imageheaders.md) method is called twice, once with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and once with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Address map translations cannot be enabled using the [IDiaAddressMap::put_addressMapEnabled](../vs140/idiaaddressmap--put_addressmapenabled.md) method unless both translation maps are provided.  
  
## See Also  
 [DiaAddressMapEntry Structure](../vs140/diaaddressmapentry.md)   
 [IDiaAddressMap](../vs140/idiaaddressmap.md)   
 [IDiaAddressMap::put_addressMapEnabled](../vs140/idiaaddressmap--put_addressmapenabled.md)   
 [IDiaAddressMap::set_imageHeaders](../vs140/idiaaddressmap--set_imageheaders.md)