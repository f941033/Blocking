# Documento de Diseño del Sistema Económico
## Videojuego de Recolección de Zanahorias

### Información del Proyecto
- **Versión**: 1.0
- **Fecha**: Junio 2025
- **Tipo**: Sistema Económico de Videojuego

---

## 1. Resumen Ejecutivo

Este documento describe el diseño del sistema económico para un videojuego de recolección de zanahorias, basado en una estimación de Fermi y análisis de balance económico. El sistema está diseñado para proporcionar una progresión económica sostenible que mantenga el engagement del jugador a través de mecánicas de inversión, optimización espacial y gestión de recursos.

**Valores clave del sistema:**
- Zanahoria normal: 8 monedas
- Zanahoria dorada: 25 monedas  
- Abono: 75 monedas
- Beneficio neto promedio: 51.2 monedas/partida (sin abono), 96.8 monedas/partida (con abono)

---

## 2. Mecánicas Base del Juego

### 2.1 Parámetros Fundamentales
- **Huerto**: 100 casillas dispuestas en grilla 10x10
- **Capacidad del jugador**: 5 zanahorias máximo
- **Duración de partida**: 2 minutos (120 segundos)
- **Tiempo de desplazamiento**: 40 segundos para distancia máxima (ida y vuelta)
- **Probabilidad de zanahoria**: 40% base, 60% con abono
- **Probabilidad de zanahoria dorada**: 20% del total de zanahorias
- **Ciclo de tasas**: Cada 5 partidas, costo de 200 monedas

### 2.2 Asunciones del Sistema

#### Estructura Espacial
- El huerto se organiza como una grilla rectangular de 10x10 casillas
- El carro se ubica en una esquina para maximizar la variación de distancias
- Las casillas más alejadas requieren el tiempo máximo de desplazamiento (40 segundos)
- El jugador puede optimizar rutas para visitar múltiples casillas en un solo viaje

#### Mecánicas de Movimiento
- Velocidad de movimiento constante del personaje
- Tiempo de recolección por casilla: instantáneo o despreciable
- El jugador desarrolla estrategias de pathing eficientes con la experiencia
- Estimación de 4 viajes por partida con rutas optimizadas

#### Comportamiento del Jugador
- Optimización de rutas para maximizar zanahorias recolectadas
- Priorización de zanahorias doradas cuando se detectan
- Planificación de inversiones en abono basada en análisis costo-beneficio
- Adaptación de estrategias según recursos disponibles

---

## 3. Intención de Diseño de Valores Parametrizados

### 3.1 Precios de Zanahorias

#### Zanahoria Normal (8 monedas)
**Intención**: Establecer una base económica estable que cubra los costos operativos básicos.
- Permite mantener un flujo de ingresos constante y predecible
- Genera suficientes ingresos para cubrir las tasas obligatorias (40 monedas/partida)
- Proporciona un margen de beneficio modesto que incentiva la continuidad

#### Zanahoria Dorada (25 monedas - Multiplicador 3.125x)
**Intención**: Crear momentos de alta satisfacción y variabilidad en los ingresos.
- El multiplicador de 3.125x está calibrado para generar excitación sin desequilibrar la economía
- Representa aproximadamente el 30-35% de los ingresos totales a pesar de ser solo el 20% de las zanahorias
- Incentiva la exploración y toma de riesgos para encontrar estas oportunidades de alto valor

### 3.2 Precio del Abono (75 monedas)

**Intención**: Introducir una mecánica de inversión a medio plazo con ROI atractivo pero no excesivo.
- ROI de 182.4% en 3 partidas (equivalente a 28% por partida)
- Requiere planificación financiera: el jugador debe acumular capital antes de invertir
- Crea un ciclo de decisión económica que va más allá de la recolección inmediata
- El beneficio adicional (45.6 monedas/partida) justifica la inversión sin crear dependencia absoluta

### 3.3 Tasas del Huerto (200 monedas cada 5 partidas)

**Intención**: Mantener presión económica constante y evitar acumulación excesiva de recursos.
- 40 monedas por partida crean un "piso" económico que debe superarse
- Frecuencia de 5 partidas permite planificación pero mantiene urgencia
- Actúa como sink económico para prevenir inflación de recursos
- Fuerza decisiones sobre cuándo usar abono versus ahorrar para tasas

---

## 4. Reglas Fundamentales del Sistema

### 4.1 Principio de Escasez Controlada

**Definición**: El sistema mantiene una tensión económica constante sin crear frustración.

**Implementación**:
- Las tasas obligatorias previenen acumulación excesiva de riqueza
- La probabilidad del 40% de zanahorias crea incertidumbre en cada partida
- El límite de inventario (5 zanahorias) fuerza decisiones tácticas sobre cuándo regresar

**Objetivo**: Mantener cada decisión económica relevante y significativa.

### 4.2 Principio de Optimización Espacial

**Definición**: El diseño del espacio de juego recompensa la planificación estratégica.

**Implementación**:
- Diferentes distancias al carro crean trade-offs entre exploración y eficiencia
- El tiempo limitado (2 minutos) impide exploración exhaustiva
- La capacidad de inventario limitada requiere optimización de rutas

**Objetivo**: Crear profundidad estratégica en las decisiones de movimiento y exploración.

### 4.3 Principio de Inversión Gradual

**Definición**: Las mejoras requieren planificación financiera y ofrecen beneficios a medio plazo.

**Implementación**:
- El abono cuesta 75 monedas (más que el beneficio de una partida promedio)
- Duración de 3 partidas requiere compromiso temporal
- ROI atractivo pero no inmediato incentiva la paciencia

**Objetivo**: Introducir elementos de gestión financiera que trascienden la jugabilidad inmediata.

### 4.4 Principio de Variabilidad Controlada

**Definición**: La aleatoriedad crea variedad sin destruir la estrategia.

**Implementación**:
- Probabilidades fijas (40%/60% para zanahorias, 20% para doradas) son predecibles a largo plazo
- Variabilidad de resultados por partida mantiene interés
- Los valores promedio son alcanzables y planificables

**Objetivo**: Balancear emoción de lo impredecible con capacidad de planificación estratégica.

---

## 5. Análisis de Balance del Sistema

### 5.1 Flujo Económico Sostenible

El sistema genera los siguientes flujos económicos promedio:

**Sin Abono**:
- Ingresos: 91.2 monedas/partida
- Costos: 40 monedas/partida
- Beneficio neto: 51.2 monedas/partida

**Con Abono**:
- Ingresos: 136.8 monedas/partida
- Costos: 40 monedas/partida + 25 monedas/partida (abono prorrateado)
- Beneficio neto: 96.8 monedas/partida

### 5.2 Puntos de Equilibrio

- **Rentabilidad mínima**: 40 monedas/partida (cubrir tasas)
- **Punto de inversión en abono**: 75 monedas acumuladas
- **Break-even del abono**: 1.65 partidas (recuperación de inversión)
- **Beneficio total del abono**: 136.8 monedas en 3 partidas

### 5.3 Métricas de Engagement

- **Progresión económica**: +28% beneficio con inversión en abono
- **Variabilidad de ingresos**: ±30% por partida debido a aleatoriedad
- **Ciclo de decisión**: 5 partidas (ciclo de tasas) como unidad estratégica básica
- **Tiempo de accumulation**: 2-3 partidas para permitir inversión en abono

---

## 6. Consideraciones de Implementación

### 6.1 Balancing Dinámico

El sistema está diseñado para permitir ajustes finos:
- **Probabilidades**: Modificables sin afectar la lógica fundamental
- **Precios**: Escalables manteniendo los ratios establecidos
- **Tiempos**: Ajustables para diferentes habilidades de jugador

### 6.2 Métricas de Seguimiento Recomendadas

- Tiempo promedio por partida de jugadores reales
- Tasa de uso del abono por sesión de juego
- Distribución de zanahorias recolectadas por partida
- Correlación entre uso de abono y retención de jugadores

### 6.3 Escalabilidad del Sistema

El diseño permite extensiones futuras:
- Nuevos tipos de mejoras con diferentes duraciones
- Variaciones estacionales en probabilidades
- Múltiples tipos de cultivos con diferentes características
- Sistemas de progresión a largo plazo (múltiples huertos, expansiones)

---

## 7. Conclusiones

Este sistema económico proporciona una base sólida para un videojuego de recolección que combina elementos de:
- **Gestión de recursos**: A través del inventario limitado y las tasas periódicas
- **Planificación estratégica**: Via la optimización espacial y las inversiones en abono
- **Variabilidad controlada**: Mediante probabilidades balanceadas que mantienen el interés

Los valores parametrizados han sido calibrados mediante estimación de Fermi para crear un ecosistema económico donde las decisiones del jugador son significativas pero no punitivas, promoviendo el engagement a largo plazo mientras se mantiene la accesibilidad para nuevos jugadores.

El sistema está preparado para iteración y refinamiento basado en datos reales de juego, manteniendo la flexibilidad necesaria para ajustes de balance sin requerir rediseños fundamentales.
