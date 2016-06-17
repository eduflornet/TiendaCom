//----------------------------------------------------------------
// store (contains the products)
//
// NOTE: nutritional info from http://www.cspinet.org/images/fruitcha.jpg
// score legend:
// 0: below 5% of daily value (DV)
// 1: 5-10% DV
// 2: 10-20% DV
// 3: 20-40% DV
// 4: above 40% DV
//
function store() {
    this.products = [
        new product("AMC", "Apple MFi Certificado", "Syncwire Lightning Cable Cargador iPhone", 12, 1.21, "Cable Cargador iPhone 1M-Nylon para iPhone 6s 6 Plus 5s 5c 5, iPad Pro Air 2, iPad mini 4 3 2, iPod touch 5th gen / 6th gen / Nano 7th gen, Gris [Nueva Versión]"),
        new product("ANK", "Anker Altavoz", "Inalámbrico Portátil Bluetooth SoundCore", 100, 1.21, "Calidad sonora superior: experimenta un sonido estéreo de excelente robustez gracias a dos conos de alto rendimiento y un exclusivo reflector de graves espiral (con patente pendiente)."),
        new product("APV", "AUKEY Type C Cable", "Cable a USB 3.0 A de nylon [ 1m *3 ] USB C.", 4, 1.21, "Cable de Carga y Sincronización para MacBook mit 12 Retina Display Macbook A1534 Google Chromebook Pixel Nokia N1 Tablet OnePlus 2"),
        new product("BSM", "Bose® SoundLink® Mini II", "Altavoz portátil Bluetooth, color perla", 167, 1.21, "Sonido excelente y graves profundos para disfrutar de cada matiz Inalámbrico y ultracompacto para disfrutar del sonido Bose® estés donde estés. Manos libres integrado para recibir llamada Avisos de voz que te guían por el proceso de emparejamiento Bluetooth. Batería recargable que ofrece hasta 16 horas de reproducción"),
        
        new product("JAP", "JBL Go Altavoz portátil", " Altavoz portátil para smartphonestablets y dispositivos MP3 (Bluetooth, recargable, entrada AUX), color cerceta", 18, 1.21, "Sonido de alta calidad de transmisión inalámbrica desde su smartphone o tableta. Batería recargable Li-ion integrada que permite 5 horas de reproducción continuada. Reciba las llamadas desde su altavoz tocando un botón, conversaciones nítidas gracias al sistema manos libres sin ruidos. Tampoco se preocupe si no hay Bluetooth, conecte el cable de audio en el altavoz y disfrute de su música del mismo modo. Diseño simple en 8 vibrantes colores"),
        
        new product("LAA", "LEPY LP-A68 Amplificador", "Amplificador Audio Mini Hi- Fi Amplificador Estereo 15W Amplificador para CD IPOD MP3 MP4 MD + Fuente de Alimentacion de CA Adaptador de Cargador DC 12V 5A", 8, 1.21, "15 W diseno del circuito de musica. Cuerpo de aluminio con excelentes acabados. Tecnologia anti -deslizante. Luz LED azul en el control de volumen redondo. Compatible con CD MD MP3 MP4 IPOD"),
        
        new product("TAA", "TaoTronics Altavoz", "Altavoz Bluetooth Ducha Impermeable", 8, 1.21, "Toma una ducha mientras cantas tus canciones favoritas Coloca tu móvil o tablet en un lugar seguro mientras disfrutas de música o realizas llamadas en la ducha, gracias al Bluetooth Wireless 3.0 y A2DP estéreo Con la tecnología IPX4 el altavoz TaoTronics está protegido contra salpicaduras de agua, perfecto para el baño, la piscina, barcos, la playa, la bañera, el patio, etc. 5-6 horas de reproducción de audio continua. Compatible con iPhone, iPad, Android Smartphones, tablets, Windows smartphones, transmisores Bluetooth y otros dispositivos Bluetooth de música estéreo"),

    ];
    this.dvaCaption = [
        "Negligible",
        "Low",
        "Average",
        "Good",
        "Great"
    ];
    this.dvaRange = [
        "below 5%",
        "between 5 and 10%",
        "between 10 and 20%",
        "between 20 and 40%",
        "above 40%"
    ];
}
store.prototype.getProduct = function (sku) {
    for (var i = 0; i < this.products.length; i++) {
        if (this.products[i].sku == sku)
            return this.products[i];
    }
    return null;
    
}


