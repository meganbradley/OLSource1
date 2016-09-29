---
title: "IWorkerThreadClient Interface"
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
  - "ATL.IWorkerThreadClient"
  - "ATL::IWorkerThreadClient"
  - "IWorkerThreadClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IWorkerThreadClient interface"
ms.assetid: 56f4a2f5-007e-4a33-9e20-05187629f715
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IWorkerThreadClient Interface
`IWorkerThreadClient` is the interface implemented by clients of the [CWorkerThread](../VS_csharp/cworkerthread-class.md) class.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
__interface IWorkerThreadClient  
  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CloseHandle](../VS_csharp/iworkerthreadclient--closehandle.md)|Implement this method to close the handle associated with this object.|  
|[Execute](../VS_csharp/iworkerthreadclient--execute.md)|Implement this method to execute code when the handle associated with this object becomes signaled.|  
  
## Remarks  
 Implement this interface when you have code that needs to execute on a worker thread in response to a handle becoming signaled.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Classes](../VS_csharp/atl-classes.md)   
 [CWorkerThread Class](../VS_csharp/cworkerthread-class.md)