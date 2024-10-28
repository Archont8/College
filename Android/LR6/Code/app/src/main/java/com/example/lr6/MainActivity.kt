package com.example.lr6

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
//===========================================
import android.os.SystemClock
import android.widget.Button
import android.widget.Chronometer
//===========================================

class MainActivity : AppCompatActivity() {
    //=================================================
    lateinit var stopwatch: Chronometer // Хронометр
    var running = false 		// Хронометр работает?
    var offset: Long = 0 	//Базовое смещение

    //Добавление строк для ключей
    private val offsetKey = "offset"
    private val runningKey = "running"
    private val baseKey = "base"
    //================================================
    //Обновляет время stopwatch.base
    private fun setBaseTime() {
        stopwatch.base = SystemClock.elapsedRealtime() - offset
    }

    private fun saveOffset() {
        offset = SystemClock.elapsedRealtime() - stopwatch.base
    }
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        //================================================

        setContentView(R.layout.activity_main)
        //Получение ссылки на секундомер
        stopwatch = findViewById<Chronometer>(R.id.stopwatch)

        //Восстановление предыдущего состояния
        if (savedInstanceState != null) {
            offset = savedInstanceState.getLong(offsetKey)
            running = savedInstanceState.getBoolean(runningKey)
            if (running) {
                stopwatch.base = savedInstanceState.getLong(baseKey)
                stopwatch.start()
            }
            else setBaseTime()
        }

        //Кнопка start запускает секундомер, если он не работал
        val startButton = findViewById<Button>(R.id.start_button)
        startButton.setOnClickListener {
            if (!running) {
                setBaseTime()
                stopwatch.start()
                running = true
            }
        }
        //Кнопка pause останавливает секундомер, если он работал
        val pauseButton = findViewById<Button>(R.id.pause_button)
        pauseButton.setOnClickListener {
            if (running) {
                saveOffset()
                stopwatch.stop()
                running = false
            }
        }

        override fun onStop() {
            super.onStop()
            if (running) {
                saveOffset()
                stopwatch.stop()
            }
            //Код, выполняемый при остановке активности
        }

        override fun onStart() {
            super.onStart()
            //Код, выполняемый при запуске активности
        }

        onRestart() override fun onRestart() {
            super.onRestart()
            //Код, выполняемый при перезапуске активности
            if (running) {
                setBaseTime()
                stopwatch.start()
                offset = 0
            }
        }

        //Кнопка reset обнуляет offset и базовое время
        val resetButton = findViewById<Button>(R.id.reset_button)
        resetButton.setOnClickListener {
            offset  = 0
            setBaseTime()
        }
        //===========================================
        ViewCompat.setOnApplyWindowInsetsListener(
            findViewById(R.id.main)) {
                v, insets -> val systemBars =
            insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top,
                systemBars.right, systemBars.bottom)
            insets
        }
    }
}