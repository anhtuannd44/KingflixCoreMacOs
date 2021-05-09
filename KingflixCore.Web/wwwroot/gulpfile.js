const gulp = require('gulp');
const sass = require('gulp-sass');

//scss to css

gulp.task("default:styleAdmin", function () {
	return gulp.src('assets/scss/styleAdmin.scss')
		.pipe(sass())
		.pipe(gulp.dest('assets/css'));
});
gulp.task("default:styleHome", function () {
	return gulp.src('assets/scss/styleHome.scss')
		.pipe(sass())
		.pipe(gulp.dest('assets/css'));
});

gulp.task("default", gulp.series("default:styleAdmin", "default:styleHome"));