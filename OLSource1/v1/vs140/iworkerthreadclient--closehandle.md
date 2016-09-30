---
title: "IWorkerThreadClient::CloseHandle"
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
  - "CloseHandle"
  - "IWorkerThreadClient.CloseHandle"
  - "IWorkerThreadClient::CloseHandle"
  - "ATL::IWorkerThreadClient::CloseHandle"
  - "ATL.IWorkerThreadClient.CloseHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CloseHandle method"
ms.assetid: 0b424eaa-13be-489e-831e-fec518d48e7d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IWorkerThreadClient::CloseHandle
Implement this method to close the handle associated with this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hHandle*  
 The handle to be closed.  
  
## Return Value  
 Return S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The handle passed to this method was previously associated with this object by a call to [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md).  
  
## Example  
 The following code shows a simple implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATL_Utilities#135](../vs140/codesnippet/CPP/iworkerthreadclient--closehandle_1.cpp)]  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [IWorkerThreadClient Interface](../vs140/iworkerthreadclient-interface.md)   
 [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md)