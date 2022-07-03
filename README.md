# Copypaste Man
Repo for my first Unity 3D Proyect!
This is the Repo for 

Curso de SODVI Semestre 2022-2
‘C# para Videojuegos’
     Proyecto Final

Realizado por:  Luis Ernesto Ochoa Ríos aka. Tequila Freak
Contacto: www.tequilafreak.com, leor8apuma@gmail.com

Devlog (De un game en desarrollo):

🔨   Implementación del ‘Shader Gameboy’:
Después de que finalizó el curso me puse a investigar de Shaders en línea. Me metí a una página de Fb, o mejor dicho un grupo de Unity. Ahí mismo, se me recomendó el libro de ‘La biblia de Shaders’, el problema. Para estas fechas no estaba publicado el libro, casi lo acaban de publicar hace unos días. Lo compré y aún no me tienen ni fecha de entrega. El mismo autor tiene una serie de videos que han hecho de cómo implementar dichos shaders con ‘Shader Graph’ con el Universal Render Pipeline. Asi que: 

ADVERTENCIA: Si van a correr el proyecto, el proyecto lo hice en la versión 2021.3.4f1, como no estuvo inicializado el proyecto en el URP, tuve que importar el package ‘Universal Render Pipeline’, el manejador de paquetes de Unity se encargó de importar dependencias y demás. Por eso aumentó el tamaño del proyecto, o de la carpeta del proyecto. Iniciar un proyecto nuevo con ‘Unity3D (URP)’ si quieren copiar y pegar todo lo que está en los Assets.

Una vez hecho eso prácticamente seguí los pasos del siguiente video: 

https://www.youtube.com/watch?v=D_g1GXdmfOc&t=147s

Quise entender todo lo que hacía pero la verdad es que se me dificulta. Entre Shader Graph, HLSL y lo que estaba implementando en el Editor. (Además de que mi proyecto estaba en otro Render Pipeline y había que configurar eso en el proyecto en la parte de ‘graphics’ pero pues no sabía por que noob.. 😞😞 ) Al final, logré no se como hacer que el proyecto corriera con las especificaciones del video, igual aumenté el # de pixeles, del rango de píxeles del shader en el Shader Graph y logré que se viera menos pixeloso aumentando el límite superior de la variable ‘PixelSize’ del Shader Graph que nombré ‘GameBoy’. El hecho de haber hecho esto me ahorra tiempo en texturizar y así solo tenía que asignar materiales a la geometría y podía jugar así con los modelos. Ahora entiendo porque muchos están prefiriendo este tipo de Shaders, ya que agiliza el hacer un videojuego en 3D y no tienes que pensar en texturizar los modelos. En pocas palabras, menos es más. O como dicen por ahí: Usa el principio KISS: Keep it simple STUPID!

🔨Implementación de ‘Audio Manager’:

Para esta parte literal seguí un tutorial de ‘Brackeys’, prácticamente todo lo que hice de aquí en adelante fué seguir sus tutoriales, tanto de audio como del ‘Menu Principal’. Aprendí además de manejar el audio, a implementar Singletons, que en desarrollo de aplicaciones es muy utilizado, igual es importante no abusar de ellos pero para el efecto de ésta aplicación creo que fué bueno usarlo. Quizá en el futuro, como lo cree en la escena del Gameplay, lo reubique a la primer escena que se crea en el videojuego que es la del ‘menú’ y empiece a sonar quizá un soundtrack distinto (por motivos de cansancio no lo hago ahora). El Julio 2 de 2022, me puse a implementar los sonidos y las llamadas en cada función respectiva a lo que quería que sonara, tuve una bronca cuando moría y es por ello que reubique el código de un update en ‘Movimiento Jugador’, si lo dejaba en el update normal, el sonido corría después de darle click a ‘Restart’. Dicho código fué la validación de cuando muere y la hago ahora en el método ‘FixedUpdate’.

Seguí por ende éste tutorial para todo lo relacionado con el Audio:

https://www.youtube.com/watch?v=6OT43pvUyfY


🔨Implementación de ‘Splash Screen Logos’:
Aquí no hubo mucho más que tiempo para modificar el Logo de SODVI, pero si hubiese tenido el logo en Vectores me hubiese ayudado mejor porque así… no me gustó, para empezar podría ponerle color blanco o así y otra modificación es que no se vean los pixeles alrededor de las letras, eso aún puede mejorar.

🔨Implementación de ‘Enemigos’:
A los enemigos les agregué un modelo, no se ve pero el modelo que bajé de internet tenía o tiene mucha geometría y sus polígonos no son cuadrados sino triangulares, eso aún puede mejorar, pero es invertir tiempo en la ‘Retopologize’ creo retopologizar (suena feo) del modelo. Básicamente hice lo mismo que hicimos para el jugador, pero pues el enemigo está estático, quizá en un futuro igual separe geometría e igual me ponga a animar el modelo. (Aunque eso significa más tiempo… 😞😞).

🔨Implementación de ‘Menu’:
Igual seguí un tutorial del Brackeys y me faltó implementar el menú de opciones para que baje el volumen gral. Después veo cómo podría implementar eso y afectar a mi Audio Manager.

https://www.youtube.com/watch?v=zc8ac_qUXQY



CONCLUSIONES:

Pues nos dijiste que ese ya era el proyecto final pero yo si quise dar algunos extras de cosas que no vimos en el curso. En sí, el curso me ayudó a perderle el miedo a Unity, miedo que ya traía de varios intentos y experiencias previas que había tenido con la herramienta, mis conceptos de antes .. o en la época en la que lo intenté usar eran .. pues nulos la verdad. Todavía batallaba mucho con entender ‘Orientado a Objetos’, y algunos conceptos que creo son básicos cuando desarrollamos aplicaciones en general. 

Hoy, pues no me quedo quieto. Igual me bajé un libro que me ha estado ayudando con C# y el proceso, tiene código muy bueno y apenas voy en el primer capítulo pero mi plan es terminarlo para estas vacaciones, pongo una imagen de la portada:



Mi meta es tener un proyecto con interfaces implementadas y con más clases. Sentí que no usamos mucho de esos conceptos, bueno el ‘Audio Manager’ si usó una lista de objetos, me gustó mucho mucho esa parte de mi proyecto por que prácticamente es código reutilizable y lo podría usar en otros proyectos sin tener que hacer la chamba de nuevo. (SPOLIER: Lo pueden bajar de ‘library genesis’, as busquen en google y fuente infinita de libros de progra, en inglés y pdf pero .. que más da … son gratis. No lo escucharon por mi…)

Futuro del Proyecto / Alcances:

Pues de este proyecto en sí hay varias o muchas cosas que arreglar, por ejemplo … rotaba cuando estaba saltando, igual eso de generar 10 planos o prefabs en cada llamada update no me late, es usar recursos a lo bestia. Lo más seguro sería como hacer una lista random de como unos 100 elementos y hacer como una condición de si toca el último de esa lista generar unos 50 más y así … pero siempre y cuando toque el último de los planos o por ahí del plano a la mitad de la lista no se.. Sería cuestión de delimitar para no usar tantos recursos. Otra cosa es que, quizá a mi Shader le hagan falta más capas .. se me hizo muy limitado o por lo menos no usar el tono de un Gameboy normal y usar más colores ya que si sentí la restricción, pero no se eso está en veremos porque también me ayudó en no pensar mucho en las texturas. La verdad es que me gustó mucho el resultado final en la manera visual. Quizá lo use para un proyecto futuro. 

Definitivamente el Audio Manager será una herramienta que usaré en futuros proyectos y la usaré a cada rato, igual podría mejorar y sentirme más cómodo con usarla. Igual el problema con esos Singletons es que no se si los estoy destruyendo y eso a lo mejor está alentando al programa, no sé… tengo que ver que onda con cómo llamo a reproducir esos archivos. De momento, creo que es todo lo que tengo que decir del proyecto, ya ando medio fundido y me gustaría mucho saber que puede mejorar de esto, por eso dejo abierto aquí un campo de sugerencias. Les agradezco, mucho la paciencia, se que soy algo intenso, pero es por que esta facultad ya me tiene en modo así y pues igual el trabajo me ha hecho ser de alguna manera un poco exigente con mi chamba, así que .. pues si soy duro pero espero que uds tanto como yo podamos seguir aprendiendo. 

Todo es para mejorar un monstruo que … es difícil mejorar, saben como se llama? 
Industria de Juegos Mexicanos. 

Vale aquí le corto, Muchas gracias, en verdad gracias por su paciencia, felices códigos! 
PAZ! 
😀😀😀😀😀😀

Atte. Luis E. Ochoa Ríos / Tequila Freak
PSDT:  Hay un Easter Egg en el proyecto, encuéntralo y dime que sucede!! 
TIP: En esa escena sólo debes dar ‘space’ y te regresa a la escena del gameplay!



