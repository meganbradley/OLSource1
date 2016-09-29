---
title: "&lt;forward_list&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0d6bc656-7049-4651-a4bd-c9a805e47756
caps.latest.revision: 13
---
# &lt;forward_list&gt; functions
||  
|-|  
|[swap](#swap)|  
  
##  <a name="swap"></a>  swap  
 Exchanges the elements of two forward lists.  
  
```  
void swap(  
    forward_list <Type, Allocator>& _Left,  
    forward_list <Type, Allocator>& _Right  
);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|An object of type `forward_list`.|  
|`_Right`|An object of type `forward_list`.|  
  
### Remarks  
 This template function executes `_Left.swap(_Right)`.  
  
## See Also  
 [&lt;forward_list&gt;](../VS_csharp/-forward_list-.md)