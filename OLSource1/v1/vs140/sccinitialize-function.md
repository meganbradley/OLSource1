---
title: "SccInitialize Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SccInitialize"
helpviewer_keywords: 
  - "SccInitialize function"
ms.assetid: 5bc0d28b-2c68-4d43-9e51-541506a8f76e
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccInitialize Function
This function initializes the source control plug-in and provides capabilities and limits to the integrated development environment (IDE).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The source control plug-in can place a pointer to its context structure here.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The name of the program calling the source control plug-in.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] The buffer where the source control plug-in puts its own name (not to exceed <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the source control plug-in's capability flags.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in, out] The buffer where the source control plug-in puts a string that describes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter returned by the [SccOpenProject Function](../vs140/sccopenproject-function.md) and the [SccGetProjPath Function](../vs140/sccgetprojpath-function.md) (not to exceed <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] Returns the maximum permissible length for a checkout comment.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [out] Returns the maximum permissible length for other comments.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Source control initialization succeeded.|  
|SCC_E_INITIALIZEFAILED|System could not be initialized.|  
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform the specified operation.|  
|SCC_E_NONSPECFICERROR|Nonspecific failure; source control system was not initialized.|  
  
## Remarks  
 The IDE calls this function when it first loads the source control plug-in. It enables the IDE to pass certain information, such as the caller name, to the plug-in. The IDE also gets back certain information such as the maximum allowable length for comments and the plug-in's capabilities.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> points to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> pointer. The source control plug-in can allocate a structure for its own use and store a pointer to that structure in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The IDE will pass this pointer to every other VSSCI API function, allowing the plug-in to have context information available without resorting to global storage and to support multiple instances of the plug-in. This structure should be deallocated when the [SccUninitialize Function](../vs140/sccuninitialize-function.md) is called.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameters enable the IDE and the source control plug-in to exchange names. These names may be used simply to distinguish among multiple instances, or they may actually appear in menus or dialog boxes.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter is a string used as a comment to identify the auxiliary project path that is stored in the solution file and passed to the source control plug-in in a call to the [SccOpenProject Function](../vs140/sccopenproject-function.md). [!INCLUDE[vsvss](../vs140/includes/vsvss_md.md)] uses the string "SourceSafe Project:"; other source control plug-ins should refrain from using this particular string.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter gives the source control plug-in a place to store bitflags indicating the plug-in's capabilities. (For a full list of capability bitflags, see [Capability Flags](../vs140/capability-flags.md)). For instance, if the plug-in plans to write results into a caller-provided callback function, the plug-in would set the capability bit SCC_CAP_TEXTOUT. This would signal the IDE to create a window for version control results.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccUninitialize Function](../vs140/sccuninitialize-function.md)   
 [SccOpenProject Function](../vs140/sccopenproject-function.md)   
 [Capability Flags](../vs140/capability-flags.md)