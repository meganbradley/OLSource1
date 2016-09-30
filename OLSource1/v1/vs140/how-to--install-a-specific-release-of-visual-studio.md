---
title: "How to: Install a Specific Release of Visual Studio"
ms.custom: na
ms.date: "2016-09-06"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-install"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "install a specific release, Visual Studio"
ms.assetid: d69ad0f8-f0a0-438e-a0ef-777c4868f139
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Install a Specific Release of Visual Studio
We update Visual Studio setup often so that you get the most current, optimized version of our optional features.  But if you want to install an earlier release of Visual Studio 2015—for example, a pre-Update 1 release of Visual Studio with iOS support—then you must  force Visual Studio setup to use an earlier version of its feature manifest files. This article describes how to do so.  
  
## Installing the current release  
 Since the initial release of Visual Studio 2015, we've updated the setup engine and the manifest files several times.  This means that if you download the web installer from the [Visual Studio Downloads](https://www.visualstudio.com/downloads/download-visual-studio-vs) website on a clean, internet-connected machine, setup installs the latest Visual Studio 2015 update, which includes the latest product  improvements as well as  newer, recent versions of optional features and tools.  
  
## Installing earlier releases  
 You can either create and mount an ISO image, or you can download and launch the installer directly from [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) and then append the .exe file with additional command-line parameters (such as /CustomInstallPath, /Full, /InstallSelectableItems, /NoRestart, etc.) to control how Visual Studio gets installed.  
  
 The following table includes some specific point-in-time scenarios and the necessary command-line parameters you must pass to the Enterprise edition installer. (The same parameters will work with the Community or Professional edition installers as well.)  
  
|Visual Studio 2015 edition|What to run|Command-line to use|What setup does|  
|--------------------------------|-----------------|--------------------------|---------------------|  
|Visual Studio Enterprise (the latest public release)|Visual Studio Enterprise with Updates (available from   [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015))|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> **Note:**  The default behavior of this installation offers the most recent optional features and therefore, it does not require any command-line parameters.|Visual Studio setup will use the most recent feed.xml and install the most recent files|  
|Visual Studio Enterprise Update 3 (the original Update 3 without any further Update 3-era updates)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was available when Update 3 released|  
|Visual Studio Enterprise Update 2 (the original Update 2, but with updates that pre-date Update 3)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was current before Update 3 released|  
|Visual Studio Enterprise (the original Update 2 without any further Update 2-era updates)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was available when Update 2 released|  
|Visual Studio Enterprise Update 1 (the original Update 1, but with updates that pre-date Update 2)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was current before Update 2 released|  
|Visual Studio Enterprise Update 1 (the original Update 1 without any further Update 1-era updates)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was available when Update 1 released|  
|Visual Studio Enterprise (the original RTM, but with updates that pre-date Update 1)|Visual Studio Enterprise RTM (available from the  [MSDN Subscriptions download page](https://msdn.microsoft.com/en-us/subscriptions/downloads/))|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was current before Update 1 released|  
|Visual Studio Enterprise (the original RTM with no updates)|Visual Studio Enterprise RTM (available from the [MSDN Subscriptions download page](https://msdn.microsoft.com/subscriptions/downloads/))|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Visual Studio setup will use the feed.xml that was available when RTM released|  
  
> [!IMPORTANT]
>  Depending on the language that you want to use, please replace "enu" (for English) with one of the following values:  
>   
>  -   chs (for Chinese (Simplified))  
> -   cht (for Chinese (Traditional))  
> -   csy (for Czech)  
> -   deu (for German)  
> -   esn (for Spanish)  
> -   fra (for French)  
> -   ita (for Italian)  
> -   jpa (for Japanese)  
> -   kor (for Korean)  
> -   plk (for Polish)  
> -   ptb (for Portuguese)  
> -   rus (for Russian)  
> -   trk (for Turkish)  
  
## See Also  
 [Visual Studio Administrator Guide](../vs140/visual-studio-administrator-guide.md)