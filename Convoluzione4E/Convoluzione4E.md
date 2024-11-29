# Documentazione Progetto Matrici Di Convoluzione

## Gruppo: Lessi e Cangini

### 1. Breve descrizione degli obiettivi assegnati:

Realizzazione di una applicazione WPF/C#  in grado di:

* caricare un'immagine in formato JPG/PNG.
* impostare una matrice kernel.
* accedere all'immagine mediante le coordinate x/y.

###  2. Dettaglio obiettivi
---
#### 2.1 obiettivo 1

Caricazione dell'immagine esterna fornita dall'utente

#### 2.2 obiettivo 2

Applicazione dei filtri pre-impostati scelti dall'utente.

#### 2.3 obiettivo 3

Applicazione dei filtri inseriti dall'utente.

---

###  3. Risultati attesi e derivables 

#### 3.1 Risultati Principali

Vengono applicate le matrici scelte dall'utente sull'immagine da lui inserita.

#### 3.2 Risultati Secondari
#### 3.3 Derivable 1

Modificare la classe immagine in modo che sia perfettamente funzionale. (Bones)

#### 3.3 Derivable 2

Costruire la classe matrice che permetta l'applicazione della matrice stessa all'immagine data dall'utente. (muscles)

#### 3.4 Derivable 3

Implementare la classe matrice all'interno del main e creare una simil interfaccia utente. (body)

---

### 4. Considerazioni Genereali

Corretto funzionamento dell'applicazione con filtri pre-impostati e eventualmente con la possibilità dell'utente di poter inserirne di nuove;

--- 

### 5. Richieste Ulteriori

Per ora nessuna richiesta ulteriore.

---

### 6. Piano D'azione

#### 6.1 Fase 1

Modificare Il Colore R G B e A di un pixel.

    {
        int newRed;
        int newGreen;
        int newBlue;
        int newAlpha;
        Rgba32 color;

        color = img.GetColor(x, y);
        newRed = (color.R * 255);
        if(newRed > 255)
        {
            newRed = 255;
        }
        color.R = Convert.ToByte(newRed);
        newGreen = (color.G * 255);
        if(newGreen > 255)
        {
            newGreen = 255;
        }
        color.G = Convert.ToByte(newGreen);
        newBlue = (color.B * 255);
        if(newBlue > 255)
        {
            newBlue = 255;
        }
        color.B = Convert.ToByte(newBlue);
        newAlpha = (color.A * 255);
        if(newAlpha > 255)
        {
            newAlpha = 255;
        }
        color.A = Convert.ToByte(newAlpha);

        return color;
    }

#### 6.2 Fase 2 

Per tutta la larghezza dell'immagine applicare i colori dei nuovi pixel

#### 6.3 Fase 3

Ripetere l'azione precedente per tutta l'altezza

#### 6.4 Fase 4 

Formazione dell'immagine.