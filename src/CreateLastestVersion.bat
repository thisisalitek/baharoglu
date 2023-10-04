mkdir ..\installer\ProbarSiparis
xcopy BaharOgluProject\bin\Debug\*.dll ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.exe ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.sql ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.jpg ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.png ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.gif ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.bmp ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\*.ico ..\installer\ProbarSiparis /s/a/d/y
xcopy BaharOgluProject\bin\Debug\LanguageDB.xml ..\installer\ProbarSiparis /s/a/d/y
DEL ..\installer\ProbarSiparis\*vshost.exe
DEL ..\installer\ProbarSiparis\de 

DEL ..\installer\ProbarSiparis\ja 
DEL ..\installer\ProbarSiparis\es
rd ..\installer\ProbarSiparis\de

rd ..\installer\ProbarSiparis\ja
rd ..\installer\ProbarSiparis\es



