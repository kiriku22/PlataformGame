# GAME WIN FORMS

## -- Variables de Estado del Juego
#### --- goLeft: Indica si el jugador se está moviendo a la izquierda.
#### --- goRight: Indica si el jugador se está moviendo a la derecha.
#### --- isNicetry: Indica si el juego ha terminado (ganado o perdido).
#### --- score: Mantiene la puntuación del jugador.
#### --- ballx: Controla la velocidad y dirección horizontal de la bola.
#### --- bally: Controla la velocidad y dirección vertical de la bola.
#### --- playerSpeed: La velocidad de movimiento del jugador.
#### --- rnd: Generador de números aleatorios para crear colores aleatorios y modificar la velocidad de la bola.
#### --- blockArray: Array de PictureBox que representa los bloques en el juego.

## -- Métodos de Juego
#### --- Nicetry: Detiene el juego y muestra un mensaje dependiendo de si el jugador ganó o perdió.
#### --- EnemiesPlace(): Crea y posiciona 15 bloques en la ventana del juego. Llama al método setupGame para inicializar el juego.
#### --- Quitarbloques(): Elimina todos los bloques del formulario.
#### --- Erzebet: Manejador del evento del temporizador (GTimer). Mueve el jugador y la bola. Verifica colisiones con los bordes, el jugador y los bloques. Actualiza la puntuación y verifica condiciones de victoria o derrota.
#### --- Abajo: Maneja la entrada del teclado para mover el jugador a la izquierda o derecha cuando se presionan las teclas correspondientes.
#### --- Press: Maneja la entrada del teclado para detener el movimiento del jugador cuando se sueltan las teclas correspondientes. Reinicia el juego si se presiona Enter y el juego ha terminado.

# JOHN ALEJANDRO MIRANDA MELGUIZO