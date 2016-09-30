---
title: "-ResetSkipPkgs (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ResetSkipPkgs (devenv.exe)"
helpviewer_keywords: 
  - "/ResetSkipPkgs Devenv switch"
  - "Devenv, /ResetSkipPkgs switch"
  - "ResetSkipPkgs switch"
ms.assetid: 7ece64f9-cfa4-4b34-b0d9-1c338b9557b3
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ResetSkipPkgs (devenv.exe)
Clears all options to skip loading added to VSPackages by users wishing to avoid loading problem VSPackages, then starts [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The presence of a SkipLoading tag disables the loading of a VSPackage; clearing the tag re-enables the loading of the VSPackage.  
  
## Example  
 The following example clears all SkipLoading tags.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)