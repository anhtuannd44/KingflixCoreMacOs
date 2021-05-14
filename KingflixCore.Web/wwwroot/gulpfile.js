const gulp = require('gulp');
const sass = require('gulp-sass');
const concat = require('gulp-concat');
const uglify = require('gulp-uglify');

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
gulp.task("default:login", function () {
	return gulp.src('assets/scss/login.scss')
		.pipe(sass())
		.pipe(gulp.dest('assets/css'));
});

gulp.task('default:validationJs', function (done) {
	var scriptSources = [
		'lib/jquery-validate/jquery.validate.min.js',
		'lib/jquery-validate/localization/messages_vi.js',
		'lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js'
	];
    gulp.src(scriptSources)
        // name of the new file all your js files are to be bundled to.
		.pipe(concat('validation.js'))
		.pipe(uglify())
        // the destination where the new bundled file is going to be saved to.
        .pipe(gulp.dest('js'));
    done();
});

//Run Task
gulp.task("default", gulp.series(
	"default:styleAdmin",
	"default:styleHome",
	"default:login",
	"default:validationJs"
));