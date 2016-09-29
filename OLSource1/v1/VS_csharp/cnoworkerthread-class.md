---
title: "CNoWorkerThread Class"
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
  - "ATL::CNoWorkerThread"
  - "ATL.CNoWorkerThread"
  - "CNoWorkerThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CNoWorkerThread class"
ms.assetid: 29f06bae-b658-4aac-9c14-331e996d25d1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoWorkerThread Class
Use this class as the argument for the `MonitorClass` template parameter to cache classes if you want to disable dynamic cache maintenance.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CNoWorkerThread  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CNoWorkerThread::AddHandle](../Topic/CNoWorkerThread::AddHandle.md)|Non-functional equivalent of [CWorkerThread::AddHandle](../Topic/CWorkerThread::AddHandle.md).|  
|[CNoWorkerThread::AddTimer](../Topic/CNoWorkerThread::AddTimer.md)|Non-functional equivalent of [CWorkerThread::AddTimer](../Topic/CWorkerThread::AddTimer.md).|  
|[CNoWorkerThread::GetThreadHandle](../Topic/CNoWorkerThread::GetThreadHandle.md)|Non-functional equivalent of [CWorkerThread::GetThreadHandle](../Topic/CWorkerThread::GetThreadHandle.md).|  
|[CNoWorkerThread::GetThreadId](../Topic/CNoWorkerThread::GetThreadId.md)|Non-functional equivalent of [CWorkerThread::GetThreadId](../Topic/CWorkerThread::GetThreadId.md).|  
|[CNoWorkerThread::Initialize](../Topic/CNoWorkerThread::Initialize.md)|Non-functional equivalent of [CWorkerThread::Initialize](../Topic/CWorkerThread::Initialize.md).|  
|[CNoWorkerThread::RemoveHandle](../Topic/CNoWorkerThread::RemoveHandle.md)|Non-functional equivalent of [CWorkerThread::RemoveHandle](../Topic/CWorkerThread::RemoveHandle.md).|  
|[CNoWorkerThread::Shutdown](../Topic/CNoWorkerThread::Shutdown.md)|Non-functional equivalent of [CWorkerThread::Shutdown](../Topic/CWorkerThread::Shutdown.md).|  
  
## Remarks  
 This class provides the same public interface as [CWorkerThread](../VS_csharp/cworkerthread-class.md). This interface is expected to be provided by the `MonitorClass` template parameter to cache classes.  
  
 The methods in this class are implemented to do nothing. The methods that return an HRESULT always return S_OK, and the methods that return a HANDLE or thread ID always return 0.  
  
## Requirements  
 **Header:** atlutil.h  
  
##  <a name="cnoworkerthread__addhandle"></a>  CNoWorkerThread::AddHandle  
 Non-functional equivalent of [CWorkerThread::AddHandle](../Topic/CWorkerThread::AddHandle.md).  
  
```  
  
HRESULT AddHandle(  
      HANDLE /*  hObject  
    */,  
      IWorkerThreadClient * /*  pClient  
    */,  
      DWORD_PTR /*  dwParam  
    */   
   ) throw( );  
  
```  
  
### Return Value  
 Always returns S_OK.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__addtimer"></a>  CNoWorkerThread::AddTimer  
 Non-functional equivalent of [CWorkerThread::AddTimer](../Topic/CWorkerThread::AddTimer.md).  
  
```  
  
HRESULT AddTimer(  
      DWORD /*  dwInterval  
    */,  
      IWorkerThreadClient * /*  pClient  
    */,  
      DWORD_PTR /*  dwParam  
    */,  
      HANDLE * /*  phTimer  
    */   
   ) throw( );  
  
```  
  
### Return Value  
 Always returns S_OK.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__getthreadhandle"></a>  CNoWorkerThread::GetThreadHandle  
 Non-functional equivalent of [CWorkerThread::GetThreadHandle](../Topic/CWorkerThread::GetThreadHandle.md).  
  
```  
  
HANDLE GetThreadHandle( ) throw( );  
  
```  
  
### Return Value  
 Always returns NULL.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__getthreadid"></a>  CNoWorkerThread::GetThreadId  
 Non-functional equivalent of [CWorkerThread::GetThreadId](../Topic/CWorkerThread::GetThreadId.md).  
  
```  
  
DWORD GetThreadId( ) throw( );  
  
```  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__initialize"></a>  CNoWorkerThread::Initialize  
 Non-functional equivalent of [CWorkerThread::Initialize](../Topic/CWorkerThread::Initialize.md).  
  
```  
  
HRESULT Initialize( ) throw( );  
  
```  
  
### Return Value  
 Always returns S_OK.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__removehandle"></a>  CNoWorkerThread::RemoveHandle  
 Non-functional equivalent of [CWorkerThread::RemoveHandle](../Topic/CWorkerThread::RemoveHandle.md).  
  
```  
  
HRESULT RemoveHandle(  
      HANDLE /*  hObject  
    */   
   ) throw( );  
  
```  
  
### Return Value  
 Always returns S_OK.  
  
### Remarks  
 The implementation provided by this class does nothing.  
  
##  <a name="cnoworkerthread__shutdown"></a>  CNoWorkerThread::Shutdown  
 Non-functional equivalent of [CWorkerThread::Shutdown](../Topic/CWorkerThread::Shutdown.md).  
  
```  
  
HRESULT Shutdown(  
      DWORD  dwWait  
    = ATL_WORKER_THREAD_WAIT   
   ) throw( );  
  
```  
  
### Return Value  
 Always returns S_OK.  
  
### Remarks  
 The implementation provided by this class does nothing.