---
title: "Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network."
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vs.debug.remote.dcom_disabled
dev_langs: 
  - FSharp
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - DCOM, unable to connect error
ms.assetid: b584b5db-ef52-45ed-8561-1314da3cc5b8
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network.
This behavior occurs if one of the following conditions is true:  
  
-   Your connection to the remote computer was broken.  
  
-   Your user account on the remote computer is disabled.  
  
-   Your password on the remote computer has expired.  
  
### To resolve this behavior  
  
-   Make sure that the local computer and the remote computer are in the same network. To do this, use Microsoft Windows Explorer (or File Explorer) to try to access the remote computer.  
  
     — and —  
  
-   Make sure that the user account that you are using to connect to the remote computer is enabled.  
  
     — and —  
  
-   Make sure that the password that you are using to connect to the remote computer is valid and has not expired.  
  
## See Also  
 [Set Up the Remote Tools on the Device](../vs140/set-up-the-remote-tools-on-the-device.md)   
 [Debugger Settings and Preparation](../vs140/debugger-settings-and-preparation.md)