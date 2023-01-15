
; Created by Munawar Hasan

(defun xgcd (a b)

    (let ((s 0) (r b) (old_s 1) (old_r a) quotient temp bezout_t)

        (loop
            (setq quotient (floor old_r r))

            (setq temp r)
            (setq r (- old_r (* quotient r)))

            (setq old_r temp)

            (setq temp s)
            (setq s (- old_s (* quotient s)))
            (setq old_s temp)

            (when (<= r 0 ) (return r))
        )
        (if (/= b 0)
            (setq bezout_t (/ (- old_r (* old_s a)) b))
            (setq bezout_t 0)
        )

        (format t "Bézout coefficients: (~a, ~a) ~&" old_s bezout_t)
    )
)

(xgcd 2304 13)
(write-line "")