---
title: "ClickOnce Unmanaged API Reference"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "LaunchApplication [ClickOnce unmanaged]"
  - "ClickOnce, unmanaged APIs"
  - "CleanOnlineAppCache [ClickOnce unmanaged]"
  - "CleanOnlineAppCacheW interface [ClickOnce unmanaged]"
  - "GetDeploymentDataFromManifest [ClickOnce unmanaged]"
ms.assetid: ec002138-4054-456d-bcc1-79ac2f4a4fd7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClickOnce Unmanaged API Reference
[!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] unmanaged public APIs from dfshim.dll.  
  
## CleanOnlineAppCache  
 Cleans or uninstalls all online applications from the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application cache.  
  
### Return Value  
 If successful, returns S_OK; otherwise, returns an HRESULT that represents the failure. If a managed exception occurs, returns 0x80020009 (DISP_E_EXCEPTION).  
  
### Remarks  
 Calling CleanOnlineAppCache will start the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] service if it is not already running.  
  
## GetDeploymentDataFromManifest  
 Retrieves deployment information from the manifest and activation URL.  
  
### Parameters  
  
|Parameter|Description|Type|  
|---------------|-----------------|----------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|A pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|LPCWSTR|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|LPCWSTR|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A pointer to a buffer to receive a NULL-terminated string that specifies the full application identity returned.|LPWSTR|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A pointer to a DWORD that is the length of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> buffer, in WCHARs. This includes the space for the NULL termination character.|LPDWORD|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|A pointer to a buffer to receive a NULL-terminated string that specifies the processor architecture of the application deployment, from the manifest.|LPWSTR|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A pointer to a DWORD that is the length of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> buffer, in WCHARs.|LPDWORD|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|A pointer to a buffer to receive a NULL-terminated string that specifies the codebase of the application manifest, from the manifest.|LPWSTR|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|A pointer to a DWORD that is the length of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> buffer, in WCHARs.|LPDWORD|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|A pointer to a buffer to receive a NULL-terminated string that specifies the deployment provider from the manifest, if present. Otherwise, an empty string is returned.|LPWSTR|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|A pointer to a DWORD that is the length of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|LPDWORD|  
  
### Return Value  
 If successful, returns S_OK; otherwise, returns an HRESULT that represents the failure. Returns HRESULTFROMWIN32(ERROR_INSUFFICIENT_BUFFER) if a buffer is too small.  
  
### Remarks  
 Pointers must not be null. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must not be empty.  
  
 It is the caller's responsibility to clean up the activation URL. For example, adding escape characters where they are needed or removing the query string.  
  
 It is the caller's responsibility to limit the input length. For example, the maximum URL length is 2KB.  
  
## LaunchApplication  
 Launches or installs an application by using a deployment URL.  
  
### Parameters  
  
|Parameter|Description|Type|  
|---------------|-----------------|----------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A pointer to a NULL-terminated string that contains the URL of the deployment manifest.|LPCWSTR|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Reserved for future use. Must be NULL.|LPVOID|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Reserved for future use. Must be 0.|DWORD|  
  
### Return Value  
 If successful, returns S_OK; otherwise, returns an HRESULT that represents the failure. If a managed exception occurs, returns 0x80020009 (DISP_E_EXCEPTION).  
  
## See Also  
 \<xref:System.Deployment.Application.DeploymentServiceCom.CleanOnlineAppCache*>