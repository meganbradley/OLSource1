---
title: "AsyncBase Class"
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
  - "async/Microsoft::WRL::AsyncBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AsyncBase class"
ms.assetid: 64259b9b-f427-4ffd-a611-e7a2f82362b2
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase Class
Implements the Windows Runtime asynchronous state machine.  
  
## Syntax  
  
```  
  
template <  
   typename TComplete,  
   typename TProgress = Details::Nil,  
   AsyncResultType resultType = SingleResult  
>  
class AsyncBase : public AsyncBase< TComplete, Details::Nil, resultType >;  
  
template <  
   typename TComplete,  
   AsyncResultType resultType  
>  
class AsyncBase< TComplete, Details::Nil, resultType > : public Microsoft::WRL::Implements< IAsyncInfo >;  
```  
  
#### Parameters  
 `TComplete`  
 An event handler that is called when an asynchronous operation completes.  
  
 `TProgress`  
 An event handler that is called when a running asynchronous operation reports the current progress of the operation.  
  
 `resultType`  
 One of the [AsyncResultType](../VS_csharp/asyncresulttype-enumeration.md) enumeration values. By default, SingleResult.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncBase::AsyncBase Constructor](../VS_csharp/asyncbase--asyncbase-constructor.md)|Initializes an instance of the AsyncBase class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncBase::Cancel Method](../VS_csharp/asyncbase--cancel-method.md)|Cancels an asynchronous operation.|  
|[AsyncBase::Close Method](../VS_csharp/asyncbase--close-method.md)|Closes the asynchronous operation.|  
|[AsyncBase::FireCompletion Method](../VS_csharp/asyncbase--firecompletion-method.md)|Invokes the completion event handler, or resets the internal progress delegate.|  
|[AsyncBase::FireProgress Method](../VS_csharp/asyncbase--fireprogress-method.md)|Invokes the current progress event handler.|  
|[AsyncBase::get_ErrorCode Method](../VS_csharp/asyncbase--get_errorcode-method.md)|Retrieves the error code for the current asynchronous operation.|  
|[AsyncBase::get_Id Method](../VS_csharp/asyncbase--get_id-method.md)|Retrieves the handle of the asynchronous operation.|  
|[AsyncBase::get_Status Method](../VS_csharp/asyncbase--get_status-method.md)|Retrieves a value that indicates the status of the asynchronous operation.|  
|[AsyncBase::GetOnComplete Method](../VS_csharp/asyncbase--getoncomplete-method.md)|Copies the address of the current completion event handler to the specified variable.|  
|[AsyncBase::GetOnProgress Method](../VS_csharp/asyncbase--getonprogress-method.md)|Copies the address of the current progress event handler to the specified variable.|  
|[AsyncBase::put_Id Method](../VS_csharp/asyncbase--put_id-method.md)|Sets the handle of the asynchronous operation.|  
|[AsyncBase::PutOnComplete Method](../VS_csharp/asyncbase--putoncomplete-method.md)|Sets the address of the completion event handler to the specified value.|  
|[AsyncBase::PutOnProgress Method](../VS_csharp/asyncbase--putonprogress-method.md)|Sets the address of the progress event handler to the specified value.|  
|[AsyncBase::Start Method](../VS_csharp/asyncbase--start-method.md)|Starts the asynchronous operation.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AsyncBase::CheckValidStateForDelegateCall Method](../VS_csharp/asyncbase--checkvalidstatefordelegatecall-method.md)|Tests whether delegate properties can be modified in the current asynchronous state.|  
|[AsyncBase::CheckValidStateForResultsCall Method](../VS_csharp/asyncbase--checkvalidstateforresultscall-method.md)|Tests whether the results of an asynchronous operation can be collected in the current asynchronous state.|  
|[AsyncBase::ContinueAsyncOperation Method](../VS_csharp/asyncbase--continueasyncoperation-method.md)|Determines whether the asynchronous operation should continue processing or should halt.|  
|[AsyncBase::CurrentStatus Method](../VS_csharp/asyncbase--currentstatus-method.md)|Retrieves the status of the current asynchronous operation.|  
|[AsyncBase::ErrorCode Method](../VS_csharp/asyncbase--errorcode-method.md)|Retrieves the error code for the current asynchronous operation.|  
|[AsyncBase::OnCancel Method](../VS_csharp/asyncbase--oncancel-method.md)|When overridden in a derived class, cancels an asynchronous operation.|  
|[AsyncBase::OnClose Method](../VS_csharp/asyncbase--onclose-method.md)|When overridden in a derived class, closes an asynchronous operation.|  
|[AsyncBase::OnStart Method](../VS_csharp/asyncbase--onstart-method.md)|When overridden in a derived class, starts an asynchronous operation.|  
|[AsyncBase::TryTransitionToCompleted Method](../VS_csharp/asyncbase--trytransitiontocompleted-method.md)|Indicates whether the current asynchronous operation has completed.|  
|[AsyncBase::TryTransitionToError Method](../VS_csharp/asyncbase--trytransitiontoerror-method.md)|Indicates whether the specified error code can modify the internal error state.|  
  
## Inheritance Hierarchy  
 `AsyncBase`  
  
 `AsyncBase`  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../VS_csharp/microsoft--wrl-namespace.md)