---
title: "CAtlMap::EnableAutoRehash"
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
  - "ATL.CAtlMap.EnableAutoRehash"
  - "ATL::CAtlMap::EnableAutoRehash"
  - "EnableAutoRehash"
  - "CAtlMap.EnableAutoRehash"
  - "CAtlMap::EnableAutoRehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoRehash method"
ms.assetid: 1ba139bb-c8f7-4884-9c52-88f01006a762
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::EnableAutoRehash
Call this method to enable automatic rehashing of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When automatic rehashing is enabled (which it is by default), the number of bins in the hash table will automatically be recalculated if the load value (the ratio of the number of bins to the number of elements stored in the array) exceeds the maximum or minimum values specified at the time the map is created.  
  
 **EnableAutoRefresh** is most often used after a call to [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md)