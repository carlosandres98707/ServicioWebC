using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de miservicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class miservicio : System.Web.Services.WebService
    {
        public string sistolica, diastolica, presion, diagnostico;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }



        [WebMethod]

        public string presionHarterial(int edad, int sistolica, int diastolica)
        {

            if (edad >= 15 && edad <= 19)
            {
                if (sistolica >= 105 && sistolica <= 120 && diastolica >= 73 && diastolica <= 81)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote! <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 105 && sistolica <= 120)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 105)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";


                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";



                    }



                    if (diastolica >= 73 && diastolica <= 81)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 73)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";

                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";


                    }


                    if (sistolica > 120 || diastolica > 81)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 105 || diastolica < 73)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }



                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }

            else if (edad >= 20 && edad <= 24)
            {

                if (sistolica >= 108 && sistolica <= 132 && diastolica >= 75 && diastolica <= 83)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote! <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 108 && sistolica <= 132)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 108)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 75 && diastolica <= 83)
                    {
                        this.diastolica = "Tu presion diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 75)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 132 || diastolica > 83)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 108 || diastolica < 75)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }

            else if (edad >= 25 && edad <= 29)
            {

                if (sistolica >= 109 && sistolica <= 133 && diastolica >= 76 && diastolica <= 84)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 109 && sistolica <= 133)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 109)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 76 && diastolica <= 84)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 76)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 133 || diastolica > 84)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 109 || diastolica < 76)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }
            }

            else if (edad >= 30 && edad <= 34)
            {
                if (sistolica >= 110 && sistolica <= 134 && diastolica >= 77 && diastolica <= 85)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 110 && sistolica <= 134)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 110)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 77 && diastolica <= 85)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 77)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 134 || diastolica > 85)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 110 || diastolica < 77)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }

            else if (edad >= 35 && edad <= 39)
            {

                if (sistolica >= 111 && sistolica <= 135 && diastolica >= 78 && diastolica <= 86)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 111 && sistolica <= 135)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 111)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 78 && diastolica <= 86)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 78)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 135 || diastolica > 86)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 111 || diastolica < 78)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }
            }
            else if (edad >= 40 && edad <= 44)
            {
                if (sistolica >= 112 && sistolica <= 137 && diastolica >= 79 && diastolica <= 87)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 112 && sistolica <= 137)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 112)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 79 && diastolica <= 87)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 79)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 137 || diastolica > 87)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 112 || diastolica < 79)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }
            else if (edad >= 45 && edad <= 49)
            {

                if (sistolica >= 115 && sistolica <= 139 && diastolica >= 80 && diastolica <= 89)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 115 && sistolica <= 139)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 115)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 80 && diastolica <= 89)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 80)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 139 || diastolica > 89)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 115 || diastolica < 80)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }
                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }
            }
            else if (edad >= 50 && edad <= 54)
            {
                if (sistolica >= 116 && sistolica <= 142 && diastolica >= 81 && diastolica <= 89)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 116 && sistolica <= 142)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 116)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 81 && diastolica <= 89)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 81)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 142 || diastolica > 89)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 116 || diastolica < 81)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }


                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }
            else if (edad >= 55 && edad <= 59)
            {
                if (sistolica >= 118 && sistolica <= 144 && diastolica >= 82 && diastolica <= 90)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote!  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 118 && sistolica <= 144)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal  <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 118)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 82 && diastolica <= 90)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 82)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 144 || diastolica > 90)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 118 || diastolica < 82)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }

            }
            else if (edad >= 60 && edad <= 64)
            {

                if (sistolica >= 121 && sistolica <= 147 && diastolica >= 83 && diastolica <= 91)
                {



                    this.presion = "Tu presión arterial se encuentra Excelente.¡Sigue Cuidandote! <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    return presion;
                }
                else
                {


                    if (sistolica >= 121 && sistolica <= 147)
                    {
                        this.sistolica = "Tu presión sistolica esta encuentra dentro del rango normal <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (sistolica < 121)
                    {
                        this.sistolica = "Tu presión sistolica es muy baja   <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {

                        this.sistolica = "Tu presión sistolica es muy alta  <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }



                    if (diastolica >= 83 && diastolica <= 91)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra dentro del rango normal  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='120' low='105' high='147'></meter>";
                    }
                    else if (diastolica < 83)
                    {
                        this.diastolica = "Tu presión diastolica se encuentra muy baja <br>  <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='60' low='105' high='147' optimun='120'></meter>";
                    }
                    else
                    {
                        this.diastolica = "Tu presión diastolica se encuentra demasiado alta <br> <meter style='width:200px; height:20px' " +
                        "min='1' max='220' value='220' low='120' high='147' ></meter>";

                    }

                    if (sistolica > 147 || diastolica > 91)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipertensión</h4> <br>" +
                            "<h5 style='color:red;'>Importante:</h5> " +
                            "<p style='text-align: justify;'>Si se deja sin tratamiento, la presión arterial puede llevar a muchas afecciones médicas. " +
                            "Estas incluyen enfermedades del corazón, accidente cerebrovascular, insuficiencia renal, problemas en los ojos y " +
                            "otros problemas de salud.</p>" +
                            "<h5>Causas:</h5> " +
                            "<p style='text-align: justify;'>Muchos factores pueden afectar la presión arterial, incluso: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>La cantidad de agua y de sal que usted tiene en el cuerpo</li>" +
                            "<li>El estado de los riñones, el sistema nervioso o los vasos sanguíneos</li>" +
                            "<li>Sus niveles hormonales</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Usted tiene un riesgo más alto de sufrir hipertensión arterial si: </p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Es afroamericano</li>" +
                            "<li>Es obeso</li>" +
                            "<li>Con frecuencia está estresado o ansioso</li>" +
                            "<li>Toma demasiado alcohol (más de 1 trago al día para las mujeres y más de 2 al día para los hombres)</li>" +
                            "<li>Consume demasiada sal</li>" +
                            "<li>Tiene un antecedente familiar de hipertensión arterial</li>" +
                            "<li>Tiene diabetes</li>" +
                            "<li>Fuma</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>En la mayoría de los casos, no se presentan síntomas. " +
                            "En la mayoría de las personas, la hipertensión arterial se detecta cuando visitan a su proveedor de atención médica " +
                            "o se la hacen medir en otra parte.Debido a que no hay ningún síntoma, las personas pueden sufrir enfermedad cardíaca y problemas" +
                            " renales sin saber que tienen hipertensión arterial.</ p>" +
                            "<h5>Tratamientos:</h5>" +
                            "<p style='text-align: justify;'>El objetivo del tratamiento es reducir la presión arterial de tal manera que tenga un menor riesgo" +
                            " de presentar problemas de salud causados por la presión arterial elevada. Usted y su proveedor deben establecer una meta" +
                            " de presión arterial.</p>" +
                            "<h6 style='text-align: justify;'>Cambios estilo de vida:</h6>" +
                            "<p style='text-align: justify;'>Usted puede tomar muchas medidas para ayudar a controlar su presión arterial, como:</p>" +
                            "<ul style='text-align: left;'>" +
                            "<li>Consumir una alimentación cardiosaludable que incluya potasio y fibra.</li>" +
                            "<li>Tomar mucha agua.</li>" +
                            "<li>Hacer al menos 40 minutos de ejercicio aeróbico de moderado a vigoroso, al menos 3 a 4 días a la semana.</li>" +
                            "<li>Si fuma, dejar de hacerlo.</li>" +
                            "<li>Reducir la cantidad de alcohol que toma a 1 trago al día para las mujeres y 2 para los hombres o menos.</li>" +
                            "<li>Reducir la cantidad de sodio (sal) que consume. Intente consumir menos de 1,500 mg por día.</li>" +
                            "<li>Reducir el estrés. Trate de evitar factores que le causen estrés, y pruebe con meditación o yoga para desestresarse.</li>" +
                            "<li>Mantener un peso corporal saludable.</li>" +
                            "</ul>" +
                            "<h6 style='text-align: justify;'>Medicamentos:</h6>" +
                            "<h5 style='color:red;'>Warning</h5>" +
                            "<b><p style='text-align: justify;'>Nunca por ningun motivo se automedique, " +
                            "ya que esto  puede generarle un riesgo muy grande a su salud , ademas de causarle complicaciones mucho mas gravez a futuro." +
                            "Siempre consulte a su medico de confianza  antes de tomar y/o comprar cualquier medicamento</p></b>" +
                            "<p style='text-align: justify;'>En la mayoría de las ocasiones, su proveedor probará primero indicar cambios de su estilo de vida," +
                            " y revisará su presión arterial dos o más veces. Es probable que se inicie un tratamiento con medicamentos si sus lecturas" +
                            " de presión arterial permanecen cerca o por encima de los siguientes niveles:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Número superior (presión sistólica) de 130 o más </li>" +
                            "<li>Número inferior (presión diastólica) de 80 o más</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Hay muchos diferentes medicamentos para tratar la hipertensión arterial entre los cuales se encuentran:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li> <b>Los diuréticos</b> también se denominan píldoras de agua. Ayudan a los riñones a eliminar algo de sal (sodio) del cuerpo. " +
                            "Como resultado, los vasos sanguíneos no tienen que contener tanto líquido y su presión arterial baja.</li>" +
                            "<li> <b>Los betabloqueadores</b> hacen que el corazón palpite a una tasa más lenta y con menos fuerza.</li>" +
                            "<li><b>Los inhibidores de la enzima convertidora de angiotensina</b> (también llamados <b>inhibidores de la ECA</b>) relajan los vasos sanguíneos," +
                            " lo cual reduce su presión arterial.</li>" +
                            "<li><b>Los bloqueadores de los receptores de angiotensina II</b> (también llamados<b> BRA </b>) funcionan más o menos de la misma manera " +
                            "que los inhibidores de la enzima convertidora de angiotensina.</li>" +
                            "<li> <b>Los bloqueadores de los canales del calcio </b> relajan los vasos sanguíneos al reducir el calcio que entra en las células.</li>" +
                            "</ul>";

                    }

                    else if (sistolica < 121 || diastolica < 83)
                    {

                        this.diagnostico = "<h4>Diagnostico: Hipotensión</h4> <br>" +
                            "<p style='text-align: justify;'>Sucede cuando la presión arterial es mucho más baja de lo normal. " +
                            "Esto significa que el corazón, el cerebro y otras partes del cuerpo no reciben suficiente sangre.</p>" +
                            "<h5>Causas:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial varía de una persona a otra. Una caída de solo 20 mm Hg puede ocasionar problemas para algunas personas. " +
                            "Existen distintos tipos y causas de la presión arterial baja.Ciertos medicamentos y sustancias pueden llevar a una presión arterial baja, por ejemplo:" +
                            "</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Alcohol</li>" +
                            "<li>Ansiolíticos</li>" +
                            "<li>Ciertos antidepresivos</li>" +
                            "<li>Diuréticos</li>" +
                            "<li>Medicamentos para el corazón, entre estos los que se utilizan para tratar la presión arterial alta y la enfermedad coronaria</li>" +
                            "<li>Medicamentos utilizados para cirugía</li>" +
                            "<li>Analgésicos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Otras causas de presión arterial baja incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Lesión nerviosa a causa de la diabetes</li>" +
                            "<li>Cambios en el ritmo cardíaco (arritmias)</li>" +
                            "<li>No beber suficientes líquidos (deshidratación)</li>" +
                            "<li>Insuficiencia cardíaca</li>" +
                            "</ul>" +
                            "<h5>Sintomas:</h5>" +
                            "<p style='text-align: justify;'>Los síntomas de la presión arterial baja pueden incluir:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Visión borrosa</li>" +
                            "<li>Confusión</li>" +
                            "<li>Vértigo</li>" +
                            "<li>Desmayo (síncope)</li>" +
                            "<li>Mareo</li>" +
                            "<li>Náuseas o vómitos</li>" +
                            "<li>Somnolencia</li>" +
                            "<li>Debilidad</li>" +
                            "</ul>" +
                            "<h5>Tratamiento:</h5>" +
                            "<p style='text-align: justify;'>La presión arterial más baja de lo normal en una persona sana que no causa ningún síntoma a menudo no requiere tratamiento." +
                            " En los demás casos, el tratamiento depende de la causa de su presión arterial baja y de sus síntomas." +
                            "Cuando tenga síntomas de una caída en la presión arterial, siéntese o acuéstese de inmediato." +
                            " Posteriormente levante sus pies por encima del nivel de su corazón.La hipotensión grave causada por un shock es una emergencia." +
                            " A usted se le puede administrar:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Sangre por vía intravenosa</li>" +
                            "<li>Medicamentos para aumentar la presión arterial y mejorar la fuerza cardíaca</li>" +
                            "<li>Otros medicamentos, como antibióticos</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;' >Los tratamientos para la presión arterial baja luego de levantarse demasiado rápido incluyen:</p>" +
                            "<ul style='text-align: justify;'>" +
                            "<li>Si los medicamentos son la causa, su proveedor puede cambiar la dosis o administrar un fármaco distinto." +
                            " NO deje de tomar ningún medicamento sin antes hablar con su proveedor.</li>" +
                            "<li>Su proveedor puede sugerirle que beba más líquidos para tratar la deshidratación.</li>" +
                            "<li>Usar medias de compresión puede ayudar a evitar que la sangre se acumule en las piernas. " +
                            "Esto mantiene más sangre en la parte superior del cuerpo.</li>" +
                            "</ul>" +
                            "<p style='text-align: justify;'>Las personas con hipotensión mediada neuralmente deben evitar los desencadenantes, " +
                            "como permanecer de pie por un período prolongado. Otros tratamientos incluyen tomar mucho líquido e incrementar la cantidad de sal" +
                            " en la dieta. Hable con su proveedor antes de probar estas medidas. En casos graves, se pueden prescribir medicamentos.</ p>" +
                            "<h5>Expectativas(pronóstico):</h5>" +
                            "<p style='text-align: justify;'>La presión arterial baja generalmente se puede tratar de manera efectiva.</p>";

                    }

                    return this.sistolica + "<br>" + this.diastolica + "<br><br>" + this.diagnostico;


                }
            }
            else
            {

                return "Lo siento tu rango de edad no se encuentra registrado";

            }






        }


    }
}
