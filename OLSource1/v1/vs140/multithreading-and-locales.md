---
title: "Multithreading and Locales"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locales [C++], multithreading"
  - "multithreading [C++], locales"
  - "threading [C++], locales"
  - "per-thread locale"
ms.assetid: d6fb159a-eaca-4130-a51a-f95d62f71485
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multithreading and Locales
Both the C Runtime Library and the Standard C++ Library provide support for changing the locale of your program. This topic discusses issues that arise when using the locale functionality of both libraries in a multithreaded application.  
  
## Remarks  
 With the C Runtime Library, you can create multithreaded applications using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> functions. This topic only covers multithreaded applications created using these functions. For more information, see [_beginthread, _beginthreadex](../vs140/_beginthread--_beginthreadex.md).  
  
 To change the locale using the C Runtime Library, use the [setlocale](../vs140/setlocale.md) function. In previous versions of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], this function would always modify the locale throughout the entire application. There is now support for setting the locale on a per-thread basis. This is done using the [_configthreadlocale](../vs140/_configthreadlocale.md) function. To specify that [setlocale](../vs140/setlocale.md) should only change the locale in the current thread, call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in that thread. Conversely, calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will cause that thread to use the global locale, and any call to [setlocale](../vs140/setlocale.md) in that thread will change the locale in all threads that have not explicitly enabled per-thread locale.  
  
 To change the locale using the C++ Runtime Library, use the [locale Class](../vs140/locale-class.md). By calling the [locale::global](../vs140/locale--global.md) method, you change the locale in every thread that has not explicitly enabled per-thread locale. To change the locale in a single thread or portion of an application, simply create an instance of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object in that thread or portion of code.  
  
> [!NOTE]
>  Calling [locale::global](../vs140/locale--global.md) changes the locale for both the Standard C++ Library and the C Runtime Library. However, calling [setlocale](../vs140/setlocale.md) only changes the locale for the C Runtime Library; the Standard C++ Library is not affected.  
  
 The following examples show how to use the [setlocale](../vs140/setlocale.md) function, the [locale Class](../vs140/locale-class.md), and the [_configthreadlocale](../vs140/_configthreadlocale.md) function to change the locale of an application in several different scenarios.  
  
## Example  
 In this example, the main thread spawns two child threads. The first thread, Thread A, enables per-thread locale by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The second thread, Thread B, as well as the main thread, do not enable per-thread locale. Thread A then proceeds to change the locale using the [setlocale](../vs140/setlocale.md) function of the C Runtime Library.  
  
 Since Thread A has per-thread locale enabled, only the C Runtime Library functions in Thread A start using the "french" locale. The C Runtime Library functions in Thread B and in the main thread continue to use the "C" locale. Also, since [setlocale](../vs140/setlocale.md) does not affect the Standard C++ Library locale, all Standard C++ Library objects continue to use the "C" locale.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **[Thread A] Per-thread locale is enabled.**  
**[Thread A] CRT locale is set to "French_France.1252"**  
**[Thread A] locale::global is set to "C"**  
**[Thread B] Per-thread locale is NOT enabled.**  
**[Thread B] CRT locale is set to "C"**  
**[Thread B] locale::global is set to "C"**  
**[Thread main] Per-thread locale is NOT enabled.**  
**[Thread main] CRT locale is set to "C"**  
**[Thread main] locale::global is set to "C"**   
## Example  
 In this example, the main thread spawns two child threads. The first thread, Thread A, enables per-thread locale by calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The second thread, Thread B, as well as the main thread, do not enable per-thread locale. Thread A then proceeds to change the locale using the [locale::global](../vs140/locale--global.md) method of the Standard C++ Library.  
  
 Since Thread A has per-thread locale enabled, only the C Runtime Library functions in Thread A start using the "french" locale. The C Runtime Library functions in Thread B and in the main thread continue to use the "C" locale. However, since the [locale::global](../vs140/locale--global.md) method changes the locale "globally", all Standard C++ Library objects in all threads start using the "french" locale.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[Thread A] Per-thread locale is enabled.**  
**[Thread A] CRT locale is set to "French_France.1252"**  
**[Thread A] locale::global is set to "French_France.1252"**  
**[Thread B] Per-thread locale is NOT enabled.**  
**[Thread B] CRT locale is set to "C"**  
**[Thread B] locale::global is set to "French_France.1252"**  
**[Thread main] Per-thread locale is NOT enabled.**  
**[Thread main] CRT locale is set to "C"**  
**[Thread main] locale::global is set to "French_France.1252"**   
## Example  
 In this example, the main thread spawns two child threads. The first thread, Thread A, enables per-thread locale by calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The second thread, Thread B, as well as the main thread, do not enable per-thread locale. Thread B then proceeds to change the locale using the [setlocale](../vs140/setlocale.md) function of the C Runtime Library.  
  
 Since Thread B does not have per-thread locale enabled, the C Runtime Library functions in Thread B and in the main thread start using the "french" locale. The C Runtime Library functions in Thread A continue to use the "C" locale because Thread A has per-thread locale enabled. Also, since [setlocale](../vs140/setlocale.md) does not affect the Standard C++ Library locale, all Standard C++ Library objects continue to use the "C" locale.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **[Thread B] Per-thread locale is NOT enabled.**  
**[Thread B] CRT locale is set to "French_France.1252"**  
**[Thread B] locale::global is set to "C"**  
**[Thread A] Per-thread locale is enabled.**  
**[Thread A] CRT locale is set to "C"**  
**[Thread A] locale::global is set to "C"**  
**[Thread main] Per-thread locale is NOT enabled.**  
**[Thread main] CRT locale is set to "French_France.1252"**  
**[Thread main] locale::global is set to "C"**   
## Example  
 In this example, the main thread spawns two child threads. The first thread, Thread A, enables per-thread locale by calling <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The second thread, Thread B, as well as the main thread, do not enable per-thread locale. Thread B then proceeds to change the locale using the [locale::global](../vs140/locale--global.md) method of the Standard C++ Library.  
  
 Since Thread B does not have per-thread locale enabled, the C Runtime Library functions in Thread B and in the main thread start using the "french" locale. The C Runtime Library functions in Thread A continue to use the "C" locale because Thread A has per-thread locale enabled. However, since the [locale::global](../vs140/locale--global.md) method changes the locale "globally", all Standard C++ Library objects in all threads start using the "french" locale.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **[Thread B] Per-thread locale is NOT enabled.**  
**[Thread B] CRT locale is set to "French_France.1252"**  
**[Thread B] locale::global is set to "French_France.1252"**  
**[Thread A] Per-thread locale is enabled.**  
**[Thread A] CRT locale is set to "C"**  
**[Thread A] locale::global is set to "French_France.1252"**  
**[Thread main] Per-thread locale is NOT enabled.**  
**[Thread main] CRT locale is set to "French_France.1252"**  
**[Thread main] locale::global is set to "French_France.1252"**   
## See Also  
 [Multithreading](../vs140/multithreading-support-for-older-code--visual-c---.md)   
 [_beginthread, _beginthreadex](../vs140/_beginthread--_beginthreadex.md)   
 [_configthreadlocale](../vs140/_configthreadlocale.md)   
 [setlocale](../vs140/setlocale.md)   
 [Internationalization](../vs140/internationalization.md)   
 [Locale](../vs140/locale.md)   
 [\<clocale>](../vs140/-clocale-.md)   
 [\<locale>](../vs140/-locale-.md)   
 [locale Class](../vs140/locale-class.md)