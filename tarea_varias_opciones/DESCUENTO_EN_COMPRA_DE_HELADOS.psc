Algoritmo DESCUENTO_EN_COMPRA_DE_HELADOS
		Definir compra, descuento Como Real
		Escribir "Buen dia! Ingresar el total de la compra: "
		leer compra
		Escribir "Porfavor! ingresa una de las opciones: "
		Escribir "1 = tipo A"
		Escribir "2 = tipo B"
		Escribir "3 = tipo C"
		leer tipo
		Segun tipo Hacer
			1:
				descuento=compra*.10
			2:
				descuento=compra*.15
			3:
				descuento=compra*.20
			De Otro Modo:
				descuento=0
		Fin Segun
		Escribir "El total de la compra es: ",compra-descuento
		Escribir "El descuento aplicado es: Q",descuento
FinAlgoritmo
